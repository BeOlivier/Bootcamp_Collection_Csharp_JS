const {assert, have, to} = require('chai').should();
const expect = require('chai').expect;
const fizzbuzz = require('./fizzbuzz.js');

//expect.to.equal => === (tests equality for the specific values inside an object / array)
//expect.to.eql => == (tests equality for objects / arrays)

console.log(fizzbuzz.fizzBuzz)
describe("Fizzbuzzer tests", () => {

  it("function fizzBuzz should exist ", () => {
    fizzbuzz.should.have.property('fizzBuzz');
  })

  it("returns an array", () => {
    expect(Array.isArray(fizzbuzz.fizzBuzz([1,2,3]))).to.equal(true);
  })

  it("numbers divisible by 3 should become fizz", () => {
    expect(fizzbuzz.fizzBuzz([1,2,3])).to.eql([1, 2, 'fizz']);
  });

  it("numbers divisible by 5 should become buzz", () => {
    expect(fizzbuzz.fizzBuzz([1,2,5])).to.eql([1, 2, 'buzz']);
  });

  it("if number divisible by both 3 and 5 should become fizzbuzz", () => {
    expect(fizzbuzz.fizzBuzz([1,2,15])).to.eql([1, 2, 'fizzBuzz']);
  })

  it("If input is string should become no string allowed value", () => {
    expect(fizzbuzz.fizzBuzz([1,2,"hey im a string"])).to.eql([1,2,'No string allowed']);
  });

  it("If number is out of range should become stay in range", () => {
    expect(fizzbuzz.fizzBuzz([1,2,-1, 101])).to.eql([1,2,'Stay in range', 'Stay in range']);
  });

  it("Returns the correct array based on the arguments given", () => {
    expect(fizzbuzz.fizzBuzz([1, 2, 3, 5, 15, 106, 'ayy lmao', 'kek', 45, 77])).to.eql(
      [1, 2, 'fizz', 'buzz', 'fizzBuzz', 'Stay in range', 'No string allowed', 'No string allowed', 'fizzBuzz', 77]
    )
  })
})



