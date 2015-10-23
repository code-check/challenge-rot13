<?php

require_once 'app/ROT13.php';

class hiddenTest extends PHPUnit_Framework_TestCase
{
    function testEncrypt() {
        $this->assertEquals("", encrypt(""));
        $this->assertEquals("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz", encrypt(encrypt("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz")));
        $this->assertEquals("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz", encrypt("NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm"));
    }
}