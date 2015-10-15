using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rot13Challenge.src
{
    [TestFixture]
    public class ROT13Test : ROT13
    {
        [Test]
        public void EncryptTest()
        {
            Assert.AreEqual("Uryyb Jbeyq!", Encrypt("Hello World!"));
        }
    }
}
