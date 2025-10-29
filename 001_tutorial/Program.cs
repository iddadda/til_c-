using System;
// C# 은 공백 무시
namespace HelloWorld
{
    class Program // 클래스명 // C#에서 실행되는 모든 코드는 클래스 내부에 있어야 함
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("I am learning C#.");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);
            /*
             * 주석연습
             * 이렇게 하면 여러줄 작성 가능
             */
            Console.Write("Hello World! ");
            Console.Write("I will print on the same line.");

            // type variableName = value;
            string name = "John";
            Console.WriteLine(name);
            Console.WriteLine("My name is " + name);
            
            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int myNum = 15;
            Console.WriteLine(myNum);

            int myNum2;
            myNum2 = 20;
            Console.WriteLine(myNum2);

            int myNum3 = 10;
            myNum3 = 25;
            Console.WriteLine(myNum3);

            // other types
            int myNum4 = 5;
            double myDoubleNum = 5.99;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            // 상수const
           const int myConstNum = 10;
            // myConstNum = 15; // 오류 발생

            int x = 5;
            int y = 10;
            Console.WriteLine(x + y);

            int x1 = 5 , y1=10, z1=15;
            Console.WriteLine(x1 + y1 + z1);

            int x2, y2, z2;
            x2 = y2 = z2 = 20;
            Console.WriteLine(x2 + y2 + z2);

            int minutesPerHour = 60;
            int m = 60;

            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
            
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(4.6));

            // 문자열 길이 `Length` 속성
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            // 문자열 대문자 `ToUpper()` 메서드
            string txt2 = "Hello World!";
            Console.WriteLine(txt2.ToUpper());

            // 문자열 소문자 `ToLower()` 메서드
            string txt3 = "Hello World!";
            Console.WriteLine(txt3.ToLower());

            /*
             * 문자열 연결 방법
             * 1. 더하기 연산자 (+)
             * 2. `Concat()` 메서드
             * 3. 문자열 보간 (string interpolation) - C# 6.0 이상
             */

            string name3 = firstName + lastName;
            string name4 = String.Concat(firstName, lastName);
            string name5 = $"My full name is {firstName} {lastName}.";
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(name5);
            Console.WriteLine(firstName[0]); // 첫번째 문자 출력
            Console.WriteLine(firstName[1]);

            // 문자열 인덱스번호 찾기 `IndexOf()` 메서드
            Console.WriteLine(firstName.IndexOf("n")); // 0))

            // 특수문자 이스케이프 시퀀스
            //string txt4 = "We are the so-called "Vikings" from the north."; // 오류 발생
            string txt4 = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt4);
        }

    }

   
}

