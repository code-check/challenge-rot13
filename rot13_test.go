package rot13

import "testing"

func TestROT13Transform(t *testing.T) {
	if ROT13Transform("Uryyb Jbeyq!") != "Hello World!" {
		t.Errorf("found '%v' expected 'Hello World!'", ROT13Transform("Uryyb Jbeyq!"))
	}
}