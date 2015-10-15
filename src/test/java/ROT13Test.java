import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class ROT13Test extends ROT13 {

    @Test
    public void encryptTest() {
        assertEquals("Uryyb Jbeyq!", encrypt("Hello World!"));
    }
}
