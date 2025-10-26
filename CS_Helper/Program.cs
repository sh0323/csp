namespace CS_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("  CS 학습 보조 도구");
                Console.WriteLine("=====================================");
                Console.WriteLine(" 메뉴를 선택하세요:");
                Console.WriteLine(" 1. 진법 변환기");
                Console.WriteLine(" 2. 2의 보수 변환기");
                Console.WriteLine(" 3. 종료");
                Console.WriteLine("=====================================");
                Console.Write(">> ");
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ShowNumberBaseConverter();
                        break;
                    case "2":
                        ShowTwosComplementConverter();
                        break;
                    case "3":
                        Console.WriteLine("프로그램을 종료합니다.");
                        return;
                    default:
                        Console.WriteLine("잘못된 입력입니다. 1~3 사이의 숫자를 입력하세요.");
                        Console.WriteLine("아무 키나 누르세요...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void ShowNumberBaseConverter()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("  진법 변환기");
            Console.WriteLine("=====================================");

            int fromBase = GetBaseFromUser("어떤 진법에서 변환을 시작할까요? (2, 8, 10, 16): ");
            int toBase = GetBaseFromUser("어떤 진법으로 변환할까요? (2, 8, 10, 16): ");

            Console.Write($"변환할 {fromBase}진수 숫자를 입력하세요: ");
            string? numberToConvert = Console.ReadLine();

            if (string.IsNullOrEmpty(numberToConvert))
            {
                Console.WriteLine("입력값이 없습니다.");
            }
            else
            {
                try
                {
                    string result = NumberConverter.ConvertBase(numberToConvert, fromBase, toBase);

                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"결과: {result} ({toBase}진수)");
                    Console.WriteLine("-------------------------------------");
                }
                catch (Exception)
                {
                    Console.WriteLine($"입력한 숫자 '{numberToConvert}'는 {fromBase}진수 형식이 아닙니다.");
                }
            }

            Console.WriteLine("\n아무 키나 누르면 주 메뉴로 돌아갑니다...");
            Console.ReadKey();
        }

        private static int GetBaseFromUser(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int selectedBase) && (selectedBase == 2 || selectedBase == 8 || selectedBase == 10 || selectedBase == 16))
                {
                    return selectedBase;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 2, 8, 10, 16 중 하나의 숫자를 입력하세요.");
                }
            }
        }

        private static void ShowTwosComplementConverter()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("  2. 2의 보수 변환기");
            Console.WriteLine("=====================================");
            Console.WriteLine("입력할 숫자의 종류를 선택하세요:");
            Console.WriteLine(" 1. 2진수");
            Console.WriteLine(" 2. 10진수 (8비트 기준)");
            Console.Write(">> ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("2진수 문자열을 입력하세요: ");
                    string? binaryInput = Console.ReadLine();
                    if (string.IsNullOrEmpty(binaryInput) || !binaryInput.All(c => c == '0' || c == '1'))
                    {
                        Console.WriteLine("잘못된 입력입니다. 0과 1로만 구성된 문자열을 입력하세요.");
                    }
                    else
                    {
                        CalculateAndPrintTwosComplement(binaryInput);
                    }
                    break;
                case "2":
                    Console.Write("10진수 숫자를 입력하세요 (0 ~ 255): ");
                    if (int.TryParse(Console.ReadLine(), out int decimalInput) && decimalInput >= 0 && decimalInput <= 255)
                    {
                        string binaryString = Convert.ToString(decimalInput, 2).PadLeft(8, '0');
                        CalculateAndPrintTwosComplement(binaryString);
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 0에서 255 사이의 정수를 입력하세요.");
                    }
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }

            Console.WriteLine("\n아무 키나 누르면 주 메뉴로 돌아갑니다...");
            Console.ReadKey();
        }

        private static void CalculateAndPrintTwosComplement(string binaryInput)
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

            Console.WriteLine("-------------------------------------");
            Console.WriteLine($" 원본 ({binaryInput.Length}비트): {binaryInput}");
            Console.WriteLine($" 1의 보수: {onesComplement}");
            Console.WriteLine($" 2의 보수: {twosComplement}");
            Console.WriteLine("-------------------------------------");
        }
    }
}
