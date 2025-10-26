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
        Console.WriteLine(" 1. 10진수 -> 2/8/16진수");
        Console.WriteLine(" 2. 2/8/16진수 -> 10진수");
        Console.Write(">> ");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("10진수 숫자를 입력하세요: ");
                string? decInput = Console.ReadLine();

                if (int.TryParse(decInput, out int decimalNumber))
                {
                    string binary = Convert.ToString(decimalNumber, 2);
                    string octal = Convert.ToString(decimalNumber, 8);
                    string hex = Convert.ToString(decimalNumber, 16).ToUpper();

                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($" 2진수: {binary}");
                    Console.WriteLine($" 8진수: {octal}");
                    Console.WriteLine($"16진수: {hex}");
                    Console.WriteLine("-------------------------------------");
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 정수를 입력해주세요.");
                }
                break;
            case "2":
                Console.Write("변환할 숫자를 입력하세요: ");
                string? numInput = Console.ReadLine();
                Console.Write("입력한 숫자의 진법을 입력하세요 (2, 8, 16): ");
                string? baseInput = Console.ReadLine();

                if (int.TryParse(baseInput, out int fromBase) && (fromBase == 2 || fromBase == 8 || fromBase == 16))
                {
                    try
                    {
                        int result = Convert.ToInt32(numInput, fromBase);
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine($"10진수: {result}");
                        Console.WriteLine("-------------------------------------");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"입력한 숫자 '{numInput}'는 {fromBase}진수 형식이 아닙니다.");
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 진법입니다. 2, 8, 16 중 하나를 입력하세요.");
                }
                break;
            default:
                Console.WriteLine("잘못된 선택입니다.");
                break;
        }

        Console.WriteLine("\n아무 키나 누르면 주 메뉴로 돌아갑니다...");
        Console.ReadKey();
    }

    private static void ShowTwosComplementConverter()
    {
        Console.WriteLine("2의 보수 변환기 기능을 실행합니다. (구현 예정)");
        Console.WriteLine("아무 키나 누르세요...");
        Console.ReadKey();
    }
}
