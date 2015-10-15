var
    app = require('../app.js'),
    assert = require('chai').assert;

describe('ROT13', function () {
    it('is valid', function (done) {
        assert.equal('Uryyb Jbeyq!', app.ROT13('Hello World!'));
        done();
    });
});