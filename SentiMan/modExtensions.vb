Imports System.Runtime.CompilerServices

Module FileInfoExtensions

    <Extension()>
    Public Function InUse(ByVal f As IO.FileInfo) As Boolean
        Try
            Using fs As New IO.FileStream(f.FullName, IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.None)

            End Using
        Catch ex As IO.IOException
            Return True
        Catch ex As Exception
            Return True
        End Try
        Return False
    End Function
End Module

Module FTPExtensions

    <Extension()>
    Public Function CreateDirectoryTree(ByRef _sftp As Atp.Net.Sftp, ByVal _path As String) As Boolean
        Try
            If Not _sftp Is Nothing AndAlso _sftp.IsConnected AndAlso _path <> "" Then
                _path = _path.TrimEnd("/"c)
                Dim dir2 As String = _path

                While Not _sftp.DirectoryExists(_path)
                    Try
                        _sftp.CreateDirectory(dir2)
                        dir2 = _path
                    Catch ex As Exception
                        dir2 = dir2.Substring(0, dir2.LastIndexOf("/"c))
                    End Try
                End While

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    <Extension()>
    Public Function CreateDirectoryTree(ByRef _ftp As Atp.Net.Ftp, ByVal _path As String) As Boolean
        Try
            If Not _ftp Is Nothing AndAlso _ftp.IsConnected AndAlso _path <> "" Then
                _path = _path.TrimEnd("/"c)
                Dim dir2 As String = _path

                While Not _ftp.DirectoryExists(_path)
                    Try
                        _ftp.CreateDirectory(dir2)
                        dir2 = _path
                    Catch ex As Exception
                        dir2 = dir2.Substring(0, dir2.LastIndexOf("/"c))
                    End Try
                End While

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
End Module

Module ExceptionExtensions

    <Extension()>
    Public Function GetLineNumber(e As Exception) As ExceptionData
        Try

            Dim trace = New StackTrace(e, True)
            Dim x As New ExceptionData

            For Each frame In trace.GetFrames
                If frame.GetFileLineNumber > 0 OrElse frame.GetFileColumnNumber > 0 Then

                    x.FileLineNumber = frame.GetFileLineNumber
                    x.FileColumnNumber = frame.GetFileColumnNumber
                    x.FileName = frame.GetFileName
                    x.FileMethod = frame.GetMethod.Name

                    Exit For
                End If
            Next

            Return x
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module

Class ExceptionData
    Public Property FileLineNumber As Integer = 0
    Public Property FileColumnNumber As Integer = 0
    Public Property FileName As String = ""
    Public Property FileMethod As String = ""

    Public Overrides Function ToString() As String
        Dim str = String.Format("{4} : File: {0}, Method: {1}, Line: {2}, Column: {3}", FileName, FileMethod, FileLineNumber.ToString, FileColumnNumber.ToString, Now.ToString("yyyy-MM-dd HH:mm:ss"))
        Return str
    End Function
End Class