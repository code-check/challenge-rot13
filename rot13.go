package rot13
//BEGIN_CHALLENGE
import "strings"

const lookup = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
const transform = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm"
//END_CHALLENGE
func ROT13Transform(in string) string {
//BEGIN_CHALLENGE
	ret := ""
	for i := 0; i < len(in); i++ {
		cur := string(in[i])
		index := strings.Index(lookup, cur)
		if index >= 0 {
			ret += string(transform[index])
		} else {
			ret += cur
		}
	}
	return ret
//END_CHALLENGE
}