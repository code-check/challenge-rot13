import org.scalatest._

class ROT13Test extends FlatSpec with Matchers {
  final val cipher = new ROT13

  "ROT13" should "extend IROT13" in {
    cipher.isInstanceOf[IROT13] shouldEqual true
  }

  "Encrypt" should "validate" in {
    cipher.encrypt("Uryyb Jbeyq!") shouldEqual "Hello World!"
  }
}
