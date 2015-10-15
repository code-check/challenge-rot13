exports.ROT13 = function (str) {
    // Please write your code below
    //BEGIN_CHALLENGE
    var char, wStr = [];
    for (var i = 0; i < str.length; i++) {
        char = str.charCodeAt(i);

        // Filter 'out of range' characters
        // char >= 'A' && char <= 'Z' || char >= 'a' && char <= 'z'
        if (char >= 65 && char <= 90 || char >= 97 && char <= 122) {
            // Apply fix for A-Z or a-z
            if ((char <= 90 ? char - 64 : char - 96) <= 13)
                char += 13;
            else
                char -= 13;
        }
        wStr.push(String.fromCharCode(char));
    }
    str = wStr.join('');
    //END_CHALLENGE
    return str;
};