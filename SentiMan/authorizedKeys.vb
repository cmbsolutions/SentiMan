Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography
Imports System.Security

<Serializable>
Public Class authorizedKeys
    Implements IList(Of authorizedKey)
    Implements IDisposable

    <System.Xml.Serialization.XmlArray("items")>
    Private _internal As List(Of authorizedKey)

    Public Sub New()
        If _internal Is Nothing Then _internal = New List(Of authorizedKey)
    End Sub

    Public ReadOnly Property Count As Integer Implements ICollection(Of authorizedKey).Count
        Get
            Return _internal.Count
        End Get
    End Property

    Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of authorizedKey).IsReadOnly
        Get
            Return False
        End Get
    End Property

    Default Public Property Item(index As Integer) As authorizedKey Implements IList(Of authorizedKey).Item
        Get
            If index >= 0 AndAlso index < Count Then
                Return _internal.Item(index)
            Else
                Return Nothing
            End If
        End Get
        Set(value As authorizedKey)
            If index >= 0 AndAlso index < Count Then
                _internal.Item(index) = value
            Else
                Add(value)
            End If
        End Set
    End Property

    Public Sub Add(item As authorizedKey) Implements ICollection(Of authorizedKey).Add
        _internal.Add(item)
    End Sub

    Public Sub Clear() Implements ICollection(Of authorizedKey).Clear
        _internal.Clear()
    End Sub

    Public Sub CopyTo(array() As authorizedKey, arrayIndex As Integer) Implements ICollection(Of authorizedKey).CopyTo
        _internal.CopyTo(array, arrayIndex)
    End Sub

    Public Sub Insert(index As Integer, item As authorizedKey) Implements IList(Of authorizedKey).Insert
        _internal.Insert(index, item)
    End Sub

    Public Sub RemoveAt(index As Integer) Implements IList(Of authorizedKey).RemoveAt
        _internal.RemoveAt(index)
    End Sub

    Public Function Contains(item As authorizedKey) As Boolean Implements ICollection(Of authorizedKey).Contains
        Return _internal.Contains(item)
    End Function

    Public Function GetEnumerator() As IEnumerator(Of authorizedKey) Implements IEnumerable(Of authorizedKey).GetEnumerator
        Return _internal.GetEnumerator
    End Function

    Public Function IndexOf(item As authorizedKey) As Integer Implements IList(Of authorizedKey).IndexOf
        Return _internal.IndexOf(item)
    End Function

    Public Function Remove(item As authorizedKey) As Boolean Implements ICollection(Of authorizedKey).Remove
        Return _internal.Remove(item)
    End Function

    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Return GetEnumerator()
    End Function

    Public Sub SaveToFile(file As IO.FileInfo)
        Try
            Dim formatter As New BinaryFormatter

            If Not file.Directory.Exists Then file.Directory.Create()

            Using data As New FileStream(file.FullName, FileMode.Create, FileAccess.Write, FileShare.None)
                formatter.Serialize(data, _internal)
            End Using

            formatter = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LoadFromFile(file As IO.FileInfo)
        Try
            _internal = New List(Of authorizedKey)

            If file.Exists Then
                Dim formatter As New BinaryFormatter

                Using data As New FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Read)
                    _internal = CType(formatter.Deserialize(data), List(Of authorizedKey))
                End Using
                formatter = Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                _internal = Nothing
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class

<Serializable>
Public Class authorizedKey
    Property keyData As String
    Property description As String
End Class
