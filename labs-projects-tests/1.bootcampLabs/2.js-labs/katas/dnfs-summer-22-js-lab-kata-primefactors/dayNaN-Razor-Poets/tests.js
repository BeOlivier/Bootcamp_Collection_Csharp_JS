import chai from 'chai';
import primeFactors from './primefactors.js';

const {
  should,
} = chai.should();


describe('Primefactor tests', () => {
  it('function should return empty array for numbers < 2', () => {
    primeFactors(1).should.eqls([]);
    primeFactors(0).should.eqls([]);
    primeFactors(-2).should.eqls([]);
    primeFactors('-20').should.eqls([]);
  });

  it('function prime factor should exist', () => {
    (typeof (primeFactors)).should.equals('function');
  });

  it('function prime factor should return an array', () => {
    // expect(Array.isArray(primeFactors(1))).to.equal(true);
    Array.isArray(primeFactors(1)).should.equals(true);
  });



  it('func should drop 4 non-numbers', () => {
    primeFactors('dinosaur').should.eqls([]);
  });

  it('func should return 2 for input of 2', () => {
    primeFactors('2').should.eqls([2]);
  });
  it('func should return 2 and 5 for input 10', () => {
    primeFactors('10').should.eqls([2, 5]);
  });
  it('func should return for input 100', () => {
    primeFactors(100).should.eqls([2,2,5,5]);
  });
});
