public class ROT13 {
    public String encrypt(String sIn) {
        //BEGIN_CHALLENGE
        char[] aIn = sIn.toCharArray();
        for (int i = 0; i < aIn.length; i++) {

            // Filter 'out of range' characters
            if (aIn[i] >= 'A' && aIn[i] <= 'Z' || aIn[i] >= 'a' && aIn[i] <= 'z') {
                // Apply fix for A-Z or a-z
                if ((aIn[i] <= 'Z' ? aIn[i] - 'A' : aIn[i] - 'a') < 13)
                    aIn[i] += 13;
                else
                    aIn[i] -= 13;
            }
        }
        sIn = new String(aIn);
        //END_CHALLENGE
        return sIn;
    }
}
