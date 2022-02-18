using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        enum Choice
        {
            Scissors = 0,
            Rock = 1,
            Paper = 2
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // boolean 1byte
            bool b = true;
            b = false;
            Console.WriteLine("{0}", b);

            // float 4bytes
            float f = 3.14f;

            // double 8bytes
            double d = 3.14;

            // char 2bytes
            char c = 'A';

            // string 
            string s = "Hello";

            Console.WriteLine(s);

            // 바구니 변경
            // int a = 1000;
            // short b = (short) a;

            short sh = 1000;
            int a = (int) sh;

            int hp = 100;
            bool isDead = (hp <= 0);

            // 실행안됨 -> hp가 100이기 때문에
            if (isDead)
            {
                Console.WriteLine("You are dead!");
            }
            else
            {
                Console.WriteLine("You are alive!");
            }

            Console.WriteLine(isDead ? "Dead" : "Alive");

            Random random = new Random();
            // 가위바위보
            int aiChoice = random.Next(0, 3); // 0 ~ 2

            // 입력받은 값 Int 형으로 변환
            int choice = Convert.ToInt32(Console.ReadLine());

            // 상수 선언방법
            const int constNum = 10;
            // 선택에 따른 값 출력
            switch (choice)
            {
                case (int) Choice.Scissors:
                    Console.WriteLine("가위");
                    break;
                case (int) Choice.Rock:
                    Console.WriteLine("바위");
                    break;
                case (int) Choice.Paper:
                    Console.WriteLine("보");
                    break;
            }

            int result = Program.Add(1, 2);
            Console.WriteLine(result);

            // 참조타입 넘기기
            int number = 0;
            Program.AddOne(ref number);
            Console.WriteLine("number : {0}", number);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void AddOne(ref int num)
        {
            num += 1;
        }

        // Overloading
        static int Add(int a, float b)
        {
            return a + (int) b;
        }

        static int Factorial(int num)
        {
            if (num == 1)
            {
                return num;
            }

            return Factorial(num - 1) * num;
        }
    }
    
}