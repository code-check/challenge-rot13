<?php

require_once 'app/ROT13.php';

class ROT13Test extends PHPUnit_Framework_TestCase
{
    function testEncrypt() {
        $this->assertEquals("Hello World!", encrypt("Uryyb Jbeyq!"));
    }
}