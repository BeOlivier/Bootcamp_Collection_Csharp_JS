using System;

namespace FizzBuzz.xUnit
{
    public class FizzBuzz
    {

        public bool Checker(string[] array) => array == null || array.Length == 0 ? false : true;
        public string[] FizzBuzzer(string[] inputArr)
        {
            if (Checker(inputArr) == false)
            {
                return null;
            }
            var resultArray = new string[inputArr.Length];
            int index = 0;
            foreach(var i in inputArr)
            {
                if(int.TryParse(i, out var res) == true && res > 0)
                {
                    if ((res % 5 == 0) && (res % 3 == 0))
                    {
                        resultArray[index] = "FizzBuzz";
                        index++;
                        continue;
                    }
                    if(res % 3 == 0)
                    {
                        resultArray[index] = "Fizz";
                        index++;
                        continue;
                    }
                    if(res % 5 == 0)
                    {
                        resultArray[index] = "Buzz";
                        index++;
                        continue;
                    }   
                }
                if(int.TryParse(i, out var res2) && res2 < 0)
                {
                    resultArray[index] = "this should be a positive number";
                    index++;
                    continue;
                }
                if(int.TryParse(i, out var res3) == false)
                {
                    resultArray[index] = "incorrect string format, should be a number between 1 and 100";
                    index++;
                    continue;
                }

                // do something
                resultArray[index] = i;
                index++;
            }
            ArrayPrinter(resultArray);
            return resultArray;
        }
        public void ArrayPrinter(string[] input)
        {
            foreach(var element in input) 
            {
                System.Console.WriteLine(element);
            }
        }
    }

}
