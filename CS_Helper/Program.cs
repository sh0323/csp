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
        if (fromBase == -1) return;

        int toBase = GetBaseFromUser("어떤 진법으로 변환할까요? (2, 8, 10, 16): ");
        if (toBase == -1) return;

        Console.Write($"변환할 {fromBase}진수 숫자를 입력하세요: ");
        string? numberToConvert = Console.ReadLine();

        try
        {
            // 1. 입력된 숫자를 10진수 정수로 변환
            int decimalValue = Convert.ToInt32(numberToConvert, fromBase);

            // 2. 10진수 정수를 목표 진법의 문자열로 변환
            string result = Convert.ToString(decimalValue, toBase).ToUpper();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"결과: {result} ({toBase}진수)");
            Console.WriteLine("-------------------------------------");
        }
        catch (Exception)
        {
            Console.WriteLine($"입력한 숫자 '{numberToConvert}'는 {fromBase}진수 형식이 아닙니다.");
        }

        Console.WriteLine("\n아무 키나 누르면 주 메뉴로 돌아갑니다...");
        Console.ReadKey();
    }

    private static int GetBaseFromUser(string message)
    {
        Console.Write(message);
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int selectedBase) && (selectedBase == 2 || selectedBase == 8 || selectedBase == 10 || selectedBase == 16))
        {
            return selectedBase;
        }
        else
        {
            Console.WriteLine("잘못된 진법입니다. 2, 8, 10, 16 중 하나를 입력해야 합니다.");
            Console.WriteLine("\n아무 키나 누르면 주 메뉴로 돌아갑니다...");
            Console.ReadKey();
            return -1; // Indicates error
        }
    }

    private static void ShowTwosComplementConverter()
    {
        Console.WriteLine("2의 보수 변환기 기능을 실행합니다. (구현 예정)");
        Console.WriteLine("아무 키나 누르세요...");
        Console.ReadKey();
    }
}
