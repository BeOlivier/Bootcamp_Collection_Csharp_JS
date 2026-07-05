using System.Collections.Generic;

namespace Commodore64.Models
{
    public class Printer
    {
        private string _input;
        private Numbers _numbers;

        public Printer(Numbers nums, string putIn)
        {
            if (!string.IsNullOrEmpty(putIn))
            {
                _input = putIn.Replace("PRINT ", "").Replace("\"", "");
            }
            _numbers = nums;
        }

}
}