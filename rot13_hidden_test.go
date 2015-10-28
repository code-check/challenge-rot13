package rot13

import "testing"

const tLookup = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
const tTransform = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm"

func TestHiddenROT13Transform(t *testing.T) {
	act := ROT13Transform(ROT13Transform(tLookup))
	if act != tLookup {
		t.Errorf("expected '%v' found '%v'", tLookup, act)
	}

	act = ROT13Transform(ROT13Transform(tTransform))
	if act != tTransform {
		t.Errorf("expected '%v' found '%v'", tTransform, act)
	}

	act = ROT13Transform(tTransform)
	if act != tLookup {
		t.Errorf("expected '%v' found '%v'", tLookup, act)
	}
}