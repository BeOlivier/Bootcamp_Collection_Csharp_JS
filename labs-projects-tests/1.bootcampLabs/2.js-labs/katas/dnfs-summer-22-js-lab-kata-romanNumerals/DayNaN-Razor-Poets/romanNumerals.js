const romanNumerals = (arg) => {

  if (arg <= 0) return "";

  if (!parseInt(arg)) return "Please insert a number";

  if (arg >= 1000) return "M" + romanNumerals(arg - 1000);

  if (arg >= 900) return "CM" + romanNumerals(arg - 900);

  if (arg >= 500) return "D" + romanNumerals(arg - 500);

  if (arg >= 400) return "CD" + romanNumerals(arg - 400);

  if (arg >= 100) return "C" + romanNumerals(arg - 100);

  if (arg >= 90) return "XC" + romanNumerals(arg - 90);

  if (arg >= 50) return "L" + romanNumerals(arg - 50);

  if (arg >= 40) return "XL" + romanNumerals(arg - 40);

  if (arg >= 10) return "X" + romanNumerals(arg - 10);

  if (arg >= 9) return "IX" + romanNumerals(arg - 9);

  if (arg >= 5) return "V" + romanNumerals(arg - 5);

  if (arg >= 4) return "IV" + romanNumerals(arg - 4);

  if (arg >= 1) return "I" + romanNumerals(arg - 1);
}


//TESTS FOR MY FUNCTION
console.log(romanNumerals(100))
console.log(romanNumerals(3000))
console.log(romanNumerals(2999))
console.log(romanNumerals(1337))
console.log(romanNumerals(1950))
console.log(romanNumerals('777'))
console.log(romanNumerals("AYYYY LMAO"))