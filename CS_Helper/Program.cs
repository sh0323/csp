namespace CS_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=====================================");
                Console.WriteLine("  CS 학습 보조 도구");
                Console.WriteLine("=====================================");
                Console.ResetColor();
                Console.WriteLine(" 메뉴를 선택하세요:");
                Console.WriteLine(" 1. 진법 변환기");
                Console.WriteLine(" 2. 2의 보수 변환기");
                Console.WriteLine(" 3. 종료");
                Console.WriteLine("=====================================");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                Console.ResetColor();
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
                        PrintError("잘못된 입력입니다. 1~3 사이의 숫자를 입력하세요.");
                        Pause();
                        break;
                }
            }
        }

        private static void ShowNumberBaseConverter()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================");
            Console.WriteLine("  진법 변환기");
            Console.WriteLine("=====================================");
            Console.ResetColor();

            int fromBase = GetBaseFromUser("어떤 진법에서 변환을 시작할까요? (2, 8, 10, 16): ");
            int toBase = GetBaseFromUser("어떤 진법으로 변환할까요? (2, 8, 10, 16): ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"변환할 {fromBase}진수 숫자를 입력하세요: ");
            Console.ResetColor();
            string? numberToConvert = Console.ReadLine();

            if (string.IsNullOrEmpty(numberToConvert))
            {
                PrintError("입력값이 없습니다.");
            }
            else
            {
                try
                {
                    string result = NumberConverter.ConvertBase(numberToConvert, fromBase, toBase);
                    Console.WriteLine("-------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"결과: {result} ({toBase}진수)");
                    Console.ResetColor();
                    Console.WriteLine("-------------------------------------");
                }
                catch (Exception)
                {
                    PrintError($"입력한 숫자 '{numberToConvert}'는 {fromBase}진수 형식이 아닙니다.");
                }
            }

            Pause("주 메뉴로 돌아갑니다...");
        }

        private static int GetBaseFromUser(string message)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(message);
                Console.ResetColor();
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int selectedBase) && (selectedBase == 2 || selectedBase == 8 || selectedBase == 10 || selectedBase == 16))
                {
                    return selectedBase;
                }
                else
                {
                    PrintError("잘못된 입력입니다. 2, 8, 10, 16 중 하나의 숫자를 입력하세요.");
                }
            }
        }

        private static void ShowTwosComplementConverter()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=====================================");
                Console.WriteLine("  2. 2의 보수 변환기");
                Console.WriteLine("=====================================");
                Console.ResetColor();
                Console.WriteLine("입력할 숫자의 종류를 선택하세요:");
                Console.WriteLine(" 1. 2진수");
                Console.WriteLine(" 2. 10진수 (8비트 기준)");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                Console.ResetColor();
                string? choice = Console.ReadLine();
                string? binaryString = null;
                bool isValidOperation = false;

                switch (choice)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("2진수 문자열을 입력하세요 (최대 32자): ");
                        Console.ResetColor();
                        binaryString = Console.ReadLine();
                        if (string.IsNullOrEmpty(binaryString) || !binaryString.All(c => c == '0' || c == '1'))
                        {
                            PrintError("잘못된 입력입니다. 0과 1로만 구성된 문자열을 입력하세요.");
                        }
                        else if (binaryString.Length > 32)
                        {
                            PrintError("입력이 너무 깁니다. 32자 이하로 입력해주세요.");
                        }
                        else
                        {
                            isValidOperation = true;
                        }
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("10진수 숫자를 입력하세요 (0 ~ 255): ");
                        Console.ResetColor();
                        if (int.TryParse(Console.ReadLine(), out int decimalInput) && decimalInput >= 0 && decimalInput <= 255)
                        {
                            binaryString = Convert.ToString(decimalInput, 2).PadLeft(8, '0');
                            isValidOperation = true;
                        }
                        else
                        {
                            PrintError("잘못된 입력입니다. 0에서 255 사이의 정수를 입력하세요.");
                        }
                        break;
                    default:
                        PrintError("잘못된 선택입니다. 1 또는 2를 입력하세요.");
                        break;
                }

                if (isValidOperation && binaryString != null)
                {
                    var (onesComplement, twosComplement) = NumberConverter.GetTwosComplement(binaryString);
                    Console.WriteLine("-------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" 원본 ({binaryString.Length}비트): {binaryString}");
                    Console.WriteLine($" 1의 보수: {onesComplement}");
                    Console.WriteLine($" 2의 보수: {twosComplement}");
                    Console.ResetColor();
                    Console.WriteLine("-------------------------------------");
                    break; 
                }

                Pause("다시 시도합니다...");
            }

            Pause("주 메뉴로 돌아갑니다...");
        }

        private static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void Pause(string message = "계속하려면 아무 키나 누르세요...")
        {
            Console.WriteLine($"\n{message}");
            Console.ReadKey();
        }
    }
}
