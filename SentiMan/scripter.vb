Imports System.IO
Imports Atp

'_byteSsh = New Terminal.SshShell
'AddHandler() _byteSsh.HostKeyVerifying, AddressOf client_HostKeyVerifying

'                _byteSsh.Connect(My.Resources.byteServer)
'_byteSsh.Authenticate(My.Resources.byteUser, My.Resources.byteAvsKeyFile, "")

'_byteSsh.Timeout = 600000 'seconds 60 minutes

'Console.WriteLine("Starting extract and import: {0}", DateAndTime.Now)
'_byteSsh.ExecuteCommand(String.Format("cd {0}", My.Resources.ICD3SqlRemotePath))
'Dim extractCommand As String = String.Format(String.Format("{0}/runme{1}.sh", My.Resources.ICD3SqlRemotePath, IIf(isTest, "_test", "")))

'_byteSsh.WriteCommand(extractCommand)

'Dim res As New Text.StringBuilder

'While _byteSsh.CommandRunning
'Try
'Threading.Thread.Sleep(3000)
'_byteSsh.KeepAlive()
'Dim resi As String = _byteSsh.ReadLine

'If Not resi Is Nothing AndAlso resi <> "" Then res.AppendLine(resi)

'                        If res.ToString.Contains("OK") Then
'Exit While
'End If
'Catch ex As Terminal.TerminalException

'End Try
'End While

'Console.WriteLine("End extract and import: {0}", DateAndTime.Now)

'_byteSsh.Disconnect()
'_byteSsh.Dispose()

Public Class scripter
    Private _shell As Net.Terminal.SshShell
    Private _stdOut As New Text.StringBuilder
    Public Event NewDataEvent()

    Public Function runScript(script As String, ByRef conn As connection, ByRef keys As authorizedKeys, ParamArray Args() As KeyValuePair(Of String, String)) As Boolean
        Try
            Dim f As New FileInfo(String.Format("{0}\Scripts\{1}.txt", Environment.CurrentDirectory, script))

            If Not f.Exists Then
                _stdOut.AppendLine("Script not found")
                RaiseEvent NewDataEvent()
                Return False
            End If

            If Args.Count(Function(c) c.Key = "ssh_user" Or c.Key = "ssh_pass") = 2 Then
                connect(conn, Args.FirstOrDefault(Function(a) a.Key = "ssh_user").Value, Args.FirstOrDefault(Function(a) a.Key = "ssh_pass").Value)
            Else
                connect(conn)
            End If

            If _shell.IsConnected Then
                Using fs As New FileStream(f.FullName, FileMode.Open, FileAccess.Read, FileShare.Read)
                    Using sr As New StreamReader(fs, Text.Encoding.UTF8)

                        While Not sr.EndOfStream
                            Dim line As String = sr.ReadLine

                            If line.StartsWith("[loop_ssh_keys]") Then
                                line = line.Replace("[loop_ssh_keys]", "")

                                For Each key In keys
                                    _shell.ExecuteCommand(String.Format(line, key.keyData))
                                Next

                                _stdOut.Append(_shell.ReadToEnd)
                                RaiseEvent NewDataEvent()
                                Continue While
                            End If

                            If line.StartsWith("[private_key]") Then
                                line = line.Replace("[private_key]", "")
                                line = String.Format(line, Args.FirstOrDefault(Function(a) a.Key = "private_key").Value)
                            End If

                            _shell.ExecuteCommand(line)
                            _stdOut.Append(_shell.ReadToEnd)

                            RaiseEvent NewDataEvent()

                        End While

                    End Using
                End Using

                Return True
            End If

            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getStdOut() As String
        Try
            Dim ret As String = _stdOut.ToString

            _stdOut.Clear()
            Return ret
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function connect(ByRef conn As connection, Optional user As String = "", Optional pass As String = "") As Boolean
        Try

            _shell = New Net.Terminal.SshShell
            AddHandler _shell.HostKeyVerifying, AddressOf client_HostKeyVerifying

            _shell.Connect(conn.sshhost)

            If user = "" OrElse pass = "" Then
                _shell.Authenticate(conn.sshuser, conn.decryptedPass)
            Else
                _shell.Authenticate(user, pass)
            End If

            _stdOut.Append(_shell.ReadToEnd)
            RaiseEvent NewDataEvent()

            Return _shell.IsConnected
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub client_HostKeyVerifying(ByVal sender As Object, ByVal e As Net.HostKeyVerifyingEventArgs)
        Try
            If My.Settings.knownFingerprints.Contains(e.HostKey) Then
                e.Accept = True
            Else
                If MessageBox.Show(String.Format("Unknown fingerprint `{0}` received. Still connect?", e.HostKey), "Unknown fingerprint", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    My.Settings.knownFingerprints.Add(e.HostKey)
                    My.Settings.Save()
                    e.Accept = True
                Else
                    e.Accept = False
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class

