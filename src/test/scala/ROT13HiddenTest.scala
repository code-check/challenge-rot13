import org.scalatest._

class ROT13HiddenTest extends FlatSpec with Matchers {
  final val cipher = new ROT13

  "Encrypt" should "validate" in {
    cipher.encrypt("") shouldEqual ""
    cipher.encrypt(cipher.encrypt("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz")) shouldEqual "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
    cipher.encrypt("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz") shouldEqual "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm"
  }
}
