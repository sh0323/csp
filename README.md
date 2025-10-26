# CS_Helper

C#으로 개발하는 콘솔 기반 CS 학습 보조 도구입니다. 진법 변환 및 2의 보수 계산 기능을 제공합니다.

## 🚀 주요 기능

-   **진법 변환기**: 2, 8, 10, 16진수 간의 상호 변환을 지원합니다.
-   **2의 보수 변환기**: 2진수 또는 10진수 입력을 받아 2의 보수를 계산합니다.

## 🛠️ 빌드 및 실행 (Build and Run)

.NET SDK가 설치된 환경에서 다음 명령어를 실행하세요.

```bash
# 프로젝트 디렉터리로 이동
cd CS_Helper

# 프로그램 실행
dotnet run
```

## 📖 사용법 (How to Use)

프로그램을 실행하면 메인 메뉴가 나타납니다.

1.  **진법 변환기**:
    -   변환을 시작할 진법(2, 8, 10, 16)을 입력합니다.
    -   변환할 목표 진법(2, 8, 10, 16)을 입력합니다.
    -   숫자를 입력하면 변환된 결과가 출력됩니다.

2.  **2의 보수 변환기**:
    -   입력 종류(2진수 또는 10진수)를 선택합니다.
    -   숫자를 입력하면 원본, 1의 보수, 2의 보수 값이 출력됩니다.
    -   10진수 입력은 8비트 기준으로 처리됩니다.

3.  **종료**: 프로그램을 종료합니다.

## ✅ 개발 계획 (Development Plan)

이 프로젝트는 총 15단계의 커밋으로 나누어 개발되었습니다.

1.  `Initial commit: ...` (완료)
2.  `feat: Add main loop and menu selection structure` (완료)
3.  `feat: Implement user input handling for menu` (완료)
4.  `feat: Add placeholder functions for each menu option` (완료)
5.  `feat: Implement Decimal to any base (2, 8, 16) conversion` (완료)
6.  `feat: Implement any base (2, 8, 16) to Decimal conversion` (완료)
7.  `feat: Add user interface for selecting 'from' and 'to' bases` (완료)
8.  `refactor: Structure all conversion logic into a dedicated class` (완료)
9.  `fix: Add input validation for number base converter` (완료)
10. `feat: Implement binary string to 2's complement` (완료)
11. `feat: Allow decimal input for 2's complement` (완료)
12. `refactor: Move 2's complement logic to the converter class` (완료)
13. `fix: Add input validation for 2's complement converter` (완료)
14. `style: Improve console output formatting` (완료)
15. `docs: Update README.md with final usage instructions` (완료)