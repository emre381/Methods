
---

# Personal Information Program

## Description

This C# console application collects basic personal information (name, age, and height) from the user and displays it. Additionally, it calculates the user's birth year based on the provided age. The program uses simple input/output operations and demonstrates basic method usage.

## Features

- Prompts the user to enter their full name, age, and height.
- Displays the entered information (name, age, height).
- Calculates and displays the birth year based on the current year (2024).

## Requirements

- .NET SDK (Core or Framework) installed on your machine.

## Usage

1. Clone or download this repository to your local machine.
2. Open the project in your preferred C# IDE (like Visual Studio or Visual Studio Code).
3. Build the project.
4. Run the application.
5. Follow the on-screen prompts to enter:
   - Full name
   - Age
   - Height in meters
6. The program will display:
   - Your full name, age, and height.
   - Your estimated birth year.

## Example

Here is an example of the program in action:

```
Lütfen değerleri girin isim soy isim:
John Doe
Lütfen yaşınızı giriniz:
25
Lütfen boyunuzu metre cinsinden giriniz:
1.75
Adı ve Soyadı: John Doe Yaşınız: 25 Boyunuz: 1.75
Doğum tarihiniz: 1999
```

## Code Explanation

- **Main Method**: The entry point of the program where user input is captured and methods are called.
  - `isimSoyad`, `yas`, and `boy` are used to store the user's name, age, and height, respectively.
  - The program collects these values from the user and passes them to two different methods: `isimSoyle` and `dogunYiliHesapla`.
  
- **Methods**:
  - `isimSoyle`: Displays the user's name, age, and height.
  - `dogunYiliHesapla`: Calculates and displays the user's estimated birth year by subtracting their age from the current year (2024).

## License

This project is open-source and available under the MIT License.

---

