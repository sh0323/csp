# Development Log

개발 과정을 기록합니다.

---

### 📜 완료된 작업 (Completed Tasks)

- **(13/15) fix: Add input validation for 2's complement converter**
  - 2의 보수 변환기 기능의 입력값 검증 로직을 강화하여 안정성을 높였습니다.

- **(12/15) `c7c7f8a` - refactor: Move 2's complement logic to the converter class**
  - 2의 보수 계산 로직을 `NumberConverter` 클래스로 분리하여 코드 구조를 개선했습니다.

- **(11/15) `efc0801` - feat: Allow decimal input for 2's complement**
  - 10진수 입력을 받아 2의 보수를 계산하는 기능을 추가하고, 관련 로직을 리팩토링했습니다.

- **(10/15) `8c93d4d` - feat: Implement binary string to 2's complement**
  - 2진수 문자열을 입력받아 1의 보수와 2의 보수를 계산하는 기능을 구현했습니다.

- **(9/15) `0be8453` - fix: Add input validation for number base converter**
  - 진법 변환기 기능의 입력값 검증 로직을 강화하여 안정성을 높였습니다.

- **(8/15) `4247b04` - refactor: Structure all conversion logic into a dedicated class**
  - 진법 변환 로직을 `NumberConverter` 클래스로 분리하여 코드 구조를 개선했습니다.

- **(7/15) `3f6e42d` - feat: Add user interface for selecting 'from' and 'to' bases**
  - 진법 변환기 UI를 개선하여 모든 진법 간 변환이 가능하도록 리팩토링했습니다.

- **(6/15) `60314ce` - feat: Implement any base (2, 8, 16) to Decimal conversion**
  - 2, 8, 16진수를 입력받아 10진수로 변환하는 기능을 구현하고 하위 메뉴를 추가했습니다.

- **(5/15) `f30757a` - feat: Implement Decimal to any base (2, 8, 16) conversion**
  - 10진수를 입력받아 2, 8, 16진수로 변환하는 기능을 구현했습니다.

- **(4/15) `659d082` - feat: Add placeholder functions for each menu option**
  - `Main` 메서드의 코드를 별도 함수로 분리하여 구조를 개선했습니다.

- **(3/15) `2b02985` - feat: Implement user input handling for menu**
  - `switch` 문을 사용하여 메뉴 선택 기능을 구현했습니다.

- **(2/15) `f4af438` - feat: Add main loop and menu selection structure**
  - 프로그램의 기본이 되는 `while` 루프와 메뉴 UI를 추가했습니다.

- **(1/15) `d7716a3` - Initial commit: Add project structure and documentation**
  - 프로젝트 초기 파일 및 `.gitignore`, `README.md` 등 문서 파일을 생성했습니다.