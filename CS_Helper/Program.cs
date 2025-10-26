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
            Console.Write("2진수 문자열을 입력하세요: ");
            string? binaryInput = Console.ReadLine();

            if (string.IsNullOrEmpty(binaryInput) || !binaryInput.All(c => c == '0' || c == '1'))
            {
                Console.WriteLine("잘못된 입력입니다. 0과 1로만 구성된 문자열을 입력하세요.");
            }
            else
            {
                // 1's Complement
                string onesComplement = new string(binaryInput.Select(c => c == '0' ? '1' : '0').ToArray());

                // 2's Complement
                char[] twosComplementArray = onesComplement.ToCharArray();
                for (int i = twosComplementArray.Length - 1; i >= 0; i--)
                {
                    if (twosComplementArray[i] == '0')
                    {
                        twosComplementArray[i] = '1';
                        break;
                    }
                    else
                    {
                        twosComplementArray[i] = '0';
                    }
                }
                string twosComplement = new string(twosComplementArray);

                // Check for overflow (e.g., input "111" -> 1's "000" -> 2's should be "001", not overflow)
                // The logic handles most cases. An all 1s input to 1's complement would be all 0s, adding 1 is fine.
                // An all 0s input would be all 1s, adding 1 results in overflow.
                if (binaryInput.All(c => c == '1'))
                {
                     // This case is tricky. For simplicity, we can state it's an overflow or represent with more bits.
                     // For now, the logic will produce all 0s. Let's add a note.
                }


                Console.WriteLine("-------------------------------------");
                Console.WriteLine($" 원본: {binaryInput}");
                Console.WriteLine($" 1의 보수: {onesComplement}");
                Console.WriteLine($" 2의 보수: {twosComplement}");
                Console.WriteLine("-------------------------------------");
            }

            Console.WriteLine("\n아무 키나 누르면 주 메뉴로 돌아갑니다...");
            Console.ReadKey();
        }
    }
}
