def transform(data):
    #BEGIN_CHALLENGE
    return "".join(map(lambda x: try_transform(x), list(data)))

TABLE_LOOKUP = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
TABLE_TRANSFORM = list("NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm")

def try_transform(char):
    index = TABLE_LOOKUP.find(char)
    if index >= 0:
        return TABLE_TRANSFORM[index]
    return char
    #END_CHALLENGE

