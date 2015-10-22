Imports NUnit.Framework

<TestFixture()>
Public Class ROT13Test
    Inherits ROT13

    <Test()>
    Public Sub EncryptTest()
        Assert.AreEqual("Uryyb Jbeyq!", Encrypt("Hello World!"), "Unexpected encryption output")
    End Sub
End Class
