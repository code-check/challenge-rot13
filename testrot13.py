from nose.tools import assert_equal
from rot13 import transform

def test_transform():
    assert_equal("", transform(""))
    assert_equal("Uryyb Jbeyq!", transform("Hello World!"))