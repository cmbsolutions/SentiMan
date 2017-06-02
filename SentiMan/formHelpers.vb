﻿Imports System.Reflection

Public Class FormHelpers
    Shared ReadOnly Property ApplicationTitle(Optional ByVal extraDescription As String = "") As String
        Get
            Dim assy As Assembly = Assembly.GetExecutingAssembly
            Dim description As AssemblyDescriptionAttribute
            description = CType(assy.GetCustomAttributes(GetType(AssemblyDescriptionAttribute), False)(0), AssemblyDescriptionAttribute)
            Dim desc As String = assy.GetName.Name

            'If extraDescription <> "" Then
            '    desc = String.Format("{0} - {1}", description.Description, extraDescription)
            'Else
            '    desc = description.Description
            'End If

            If Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
                Return String.Format("{0} {1}.{2} build {3}", desc, Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Major, Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Minor, Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Build)
            Else
                Return String.Format("{0} {1}.{2} build {3} debug", desc, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build)
            End If
        End Get
    End Property

    Shared ReadOnly Property isDebug() As Boolean
        Get
            Return Not Deployment.Application.ApplicationDeployment.IsNetworkDeployed
        End Get
    End Property

    Public Shared Sub dumpException(ByRef _ex As Exception)
        Try
            Debug.IndentSize = 4
            Debug.Print(_ex.Message)
            Debug.Indent()

            Dim st As StackTrace = New StackTrace(_ex, True)
            For Each sf As StackFrame In st.GetFrames

                If sf.GetFileLineNumber > 0 OrElse sf.GetFileColumnNumber > 0 Then
                    Debug.Print("Trace line:{0}, column:{1}, file:{2}, method:{3}", sf.GetFileLineNumber, sf.GetFileColumnNumber, sf.GetFileName, sf.GetMethod.Name)
                End If

            Next
            Debug.Unindent()
        Catch ex As Exception
            Debug.Print("Can't process error")
        End Try
    End Sub
End Class
