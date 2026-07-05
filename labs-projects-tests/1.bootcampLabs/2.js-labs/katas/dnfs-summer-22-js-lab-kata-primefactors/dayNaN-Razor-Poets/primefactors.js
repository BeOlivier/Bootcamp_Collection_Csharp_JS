const primeFactors = argument => {
  if (!parseInt(argument)) return [];
  if (argument < 2) return [];

  const result = [];
  let divisor = 2;
  let arg = argument;

  while (arg >= 2) {
    if (arg % divisor === 0) {
      result.push(divisor);
      arg /= divisor;
    } else {
      divisor += 1;
    }
  }

  return result;
};

export default primeFactors;
