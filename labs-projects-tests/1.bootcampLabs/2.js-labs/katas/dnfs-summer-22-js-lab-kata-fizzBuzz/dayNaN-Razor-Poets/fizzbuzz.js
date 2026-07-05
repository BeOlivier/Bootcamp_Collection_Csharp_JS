// arg array should only have numbers
// assume we get an array
// assume we might have BAD input INSIDE the array


const fizzBuzz = (argument) => {

  for(i = 0; i < argument.length; i++) {
    if (typeof argument[i] != "number") argument[i] = "No string allowed";
    if (argument[i] < 0 || argument[i] > 100) argument[i] = "Stay in range"
    if (argument[i] % 3 == 0 && argument[i] % 5 == 0) argument[i] = 'fizzBuzz';
    if (argument[i] % 3 == 0) argument[i] = 'fizz';
    if (argument[i] % 5 == 0) argument[i] = 'buzz';
  }

  return argument;
}

const func2 = () => {};

module.exports = {fizzBuzz, func2};