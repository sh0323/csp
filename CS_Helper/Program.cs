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
            Console.WriteLine("진법 변환기 기능을 실행합니다. (구현 예정)");
            Console.WriteLine("아무 키나 누르세요...");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("2의 보수 변환기 기능을 실행합니다. (구현 예정)");
            Console.WriteLine("아무 키나 누르세요...");
            Console.ReadKey();
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
