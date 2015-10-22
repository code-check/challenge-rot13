Imports NUnit.Framework

<TestFixture()>
Public Class ROT13HiddenTest
    Inherits ROT13

    <Test()>
    Public Sub EncryptTest()
        Const LookupTable As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Const TransformTable As String = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm"

        Assert.AreEqual(TransformTable, Encrypt(LookupTable))
        Assert.AreEqual(LookupTable, Encrypt(TransformTable))
    End Sub
End Class
