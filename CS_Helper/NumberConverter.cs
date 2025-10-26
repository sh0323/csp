using System;

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
    }
}
