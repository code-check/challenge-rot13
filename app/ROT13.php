<?php

function encrypt($data) {
    //BEGIN_CHALLENGE
    //return str_rot13($data); // Ohh php...
    $lookup = "\0ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    $transform = "\0NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
    for($i = 0; $i < strlen($data); $i++) {
        $pos = strrpos($lookup, $data[$i]);
        if ($pos > 0)
            $data[$i] = $transform[$pos];
    }
    return $data;
    //END_CHALLENGE
}