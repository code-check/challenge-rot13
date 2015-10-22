Public Class ROT13
    Implements IROT13


    Public Function Encrypt(ByRef Data As String) As String Implements IROT13.Encrypt
        'BEGIN_CHALLENGE
        Dim Ret As String
        Dim i As Integer

        For i = 0 To Data.Length - 1
            Ret &= Transform(Data(i))
        Next
        Return Ret
        'END_CHALLENGE
        Throw New NotImplementedException
    End Function

    'BEGIN_CHALLENGE
    Const LookupTable As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
    Const TransformTable As String = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm"
    Public Function Transform(ByVal c As Char) As Char
        If LookupTable.Contains(c) Then
            Return TransformTable(Array.IndexOf(Of Char)(LookupTable, c))
        End If
        Return c
    End Function
    'END_CHALLENGE
End Class
