Public Class mainGUI
    Private _conns As New connections
    Private _keys As New authorizedKeys
    Private WithEvents _scripter As New scripter

    Private Sub mainGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Text = FormHelpers.ApplicationTitle

            ' load connections
            Dim connectionsFile As New IO.FileInfo(String.Format("{0}\{1}\{2}\connections.cmb", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CMBSolutions", "SentiMan"))

            If connectionsFile.Exists Then
                _conns.LoadFromFile(connectionsFile)
                cboEnv.DataSource = (From c In _conns Select c.description).ToList
                cboEnv.Refresh()
            End If

            connectionsFile = Nothing

            ' load keys
            Dim keysFile As New IO.FileInfo(String.Format("{0}\{1}\{2}\authorizedkeys.cmb", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CMBSolutions", "SentiMan"))

            If keysFile.Exists Then
                _keys.LoadFromFile(keysFile)
            End If

            keysFile = Nothing
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub ManageConnectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageConnectionsToolStripMenuItem.Click
        Try
            Dim frx As New connectionManager
            frx._conns = _conns

            If frx.ShowDialog = DialogResult.OK Then
                Dim connectionsFile As New IO.FileInfo(String.Format("{0}\{1}\{2}\connections.cmb", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CMBSolutions", "SentiMan"))

                _conns.SaveToFile(connectionsFile)
                cboEnv.DataSource = (From c In _conns Select c.description).ToList
                cboEnv.Refresh()
                connectionsFile = Nothing
            End If
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        Try
            txtPrivateKey.Text = openssl_random_preuso_bytes(63)
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Function openssl_random_preuso_bytes(Optional length As Integer = 31) As String
        If length = 0 Then length = 31
        Dim sr As New Org.BouncyCastle.Security.SecureRandom

        Dim output As String = ""
        Dim buffer(length) As Byte
        sr.NextBytes(buffer)

        For Each c In buffer
            output &= c.ToString("X2")
        Next

        Return output
    End Function

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Try
            If cboEnv.SelectedItem.ToString = "" Then ErrorProvider1.SetError(cboEnv, "Select environment")
            If txtPrivateKey.Text = "" Then ErrorProvider1.SetError(txtPrivateKey, "Enter private key")
            If txtSshAccountname.Text = "" Then ErrorProvider1.SetError(txtSshAccountname, "Enter ssh username")
            If txtSshPassword.Text = "" Then ErrorProvider1.SetError(txtSshPassword, "Enter ssh password")
            If txtDbAccountname.Text = "" Then ErrorProvider1.SetError(txtDbAccountname, "Enter database username")
            If txtDbPassword.Text = "" Then ErrorProvider1.SetError(txtDbPassword, "Enter database password")

            If cboEnv.SelectedItem.ToString <> "" AndAlso txtPrivateKey.Text <> "" AndAlso txtSshAccountname.Text <> "" AndAlso txtSshPassword.Text <> "" AndAlso txtDbAccountname.Text <> "" AndAlso txtDbPassword.Text <> "" Then

                _scripter.runScript(
                    "sshAccountSetup",
                    _conns.FirstOrDefault(Function(c) c.description = cboEnv.SelectedItem.ToString),
                    _keys,
                    New KeyValuePair(Of String, String)("private_key", txtPrivateKey.Text),
                    New KeyValuePair(Of String, String)("ssh_user", txtSshAccountname.Text),
                    New KeyValuePair(Of String, String)("ssh_pass", txtSshPassword.Text))



                dgvAccounts.Rows.Add(txtSshAccountname.Text, txtSshPassword.Text, "nvt", "nvt", txtDbAccountname.Text, txtDbPassword.Text, ".mcccm.eu", txtPrivateKey.Text, "some")
            End If

        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub ManageAuthorizedKeysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageAuthorizedKeysToolStripMenuItem.Click
        Try
            Dim frx As New authorizedKeysManager
            frx._keys = _keys

            If frx.ShowDialog = DialogResult.OK Then
                Dim keysFile As New IO.FileInfo(String.Format("{0}\{1}\{2}\authorizedkeys.cmb", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CMBSolutions", "SentiMan"))

                _keys.SaveToFile(keysFile)
                keysFile = Nothing
            End If
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub _scripter_NewDataEvent() Handles _scripter.NewDataEvent
        Try

            rtbLog.AppendText(_scripter.getStdOut())

        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        ' not implemented yet
    End Sub

    Private Sub ExportConnectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportConnectionsToolStripMenuItem.Click
        Try
            If _conns.Count = 0 Then
                MessageBox.Show("Nothing to export. Define some connections first.")
                Exit Sub
            End If

            Dim fbr As New SaveFileDialog

            fbr.Title = "Export connections"
            fbr.OverwritePrompt = True
            fbr.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            fbr.FileName = "connections.cmb"
            fbr.Filter = "SentiMan Files *.cmb | (*.cmb)"
            fbr.AddExtension = True
            fbr.DefaultExt = "cmb"

            If fbr.ShowDialog = DialogResult.OK Then
                Dim fi As New IO.FileInfo(fbr.FileName)

                If fi.Exists AndAlso Not fi.InUse Then fi.Delete()

                _conns.SaveToFile(fi)

                MessageBox.Show("Connections exported")
            End If
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub
End Class
