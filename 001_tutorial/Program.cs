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
        }
    }

   
}

