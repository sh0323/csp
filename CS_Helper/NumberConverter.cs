using System;
using System.Linq;

namespace CS_Helper
{
    public static class NumberConverter
    {
        public static string ConvertBase(string numberToConvert, int fromBase, int toBase)
        {
            // 1. 입력된 숫자를 10진수 정수로 변환 (중간 단계)
            int decimalValue = Convert.ToInt32(numberToConvert, fromBase);

            // 2. 10진수 정수를 목표 진법의 문자열로 변환
            string result = Convert.ToString(decimalValue, toBase).ToUpper();

            return result;
        }

        public static (string onesComplement, string twosComplement) GetTwosComplement(string binaryInput)
        {
            // 1's Complement
            string onesComplement = new string(binaryInput.Select(c => c == '0' ? '1' : '0').ToArray());

            // 2's Complement
            char[] twosComplementArray = onesComplement.ToCharArray();
            bool carry = true;
            for (int i = twosComplementArray.Length - 1; i >= 0; i--)
            {
                if (carry)
                {
                    if (twosComplementArray[i] == '0')
                    {
                        twosComplementArray[i] = '1';
                        carry = false;
                    }
                    else
                    {
                        twosComplementArray[i] = '0';
                    }
                }
            }
            string twosComplement = new string(twosComplementArray);

            return (onesComplement, twosComplement);
        }
    }
}
