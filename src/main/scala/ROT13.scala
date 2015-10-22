class ROT13 extends IROT13 {
  override def encrypt(data: String): String = {
    //BEGIN_CHALLENGE
    val lookup = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
    val transform = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm"
    return data.map(x => {
      val i = transform.indexOf(x)
      if (i >= 0) lookup(i) else x
    })
    //END_CHALLENGE
    ???
  }
}
