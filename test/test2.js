var
    app = require('../app.js'),
    assert = require('chai').assert;

describe('ROT13', function () {
    it('encrypts', function (done) {
        assert.equal('NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm', app.ROT13('ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz'));
        done();
    });

    it('decrypts', function (done) {
        assert.equal('ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz', app.ROT13(app.ROT13('ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz')));
        done();
    });
});