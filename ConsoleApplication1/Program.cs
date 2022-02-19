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

        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        static ClassType ChooseClass()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 마법사");

            ClassType choice = ClassType.None;

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }

            return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            player.type = choice;

            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }

        struct Player
        {
            public int hp;
            public int attack;
            public ClassType type;
        }

        static void EnterGame()
        {
            Console.WriteLine("게임 접속");
            Console.WriteLine("[1] Into Game");
            Console.WriteLine("[2] Robby");

            string input = Console.ReadLine();

            while (true)
            {
                switch (input)
                {
                    case "1":
                        EnterField();
                        break;
                    case "2":
                        return;
                }
            }
        }

        static void EnterField()
        {
            Console.WriteLine("필드에 들어왔습니다.");
            Monster monster;

            CreateRandomMonster(out monster);

            Console.WriteLine("전투모드 돌입");
        }

        struct Monster
        {
            public int hp;
            public int attack;
        }

        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }

        static void CreateRandomMonster(out Monster monster)
        {
            Random random = new Random();
            int randMonster = random.Next(1, 4);

            switch (randMonster)
            {
                case (int) MonsterType.Slime:
                    Console.WriteLine("슬라임 생성");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int) MonsterType.Orc:
                    Console.WriteLine("오크 생성");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                case (int) MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤 생성");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                ClassType choice = ChooseClass();

                if (choice != ClassType.None)
                {
                    Player player;
                    // int hp;
                    // int attack;
                    CreatePlayer(choice, out player);

                    // Console.WriteLine($"HP{player.hp} Attack{player.attack}");
                }

                break;
            }

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

            int health = 100;
            bool isDead = (health <= 0);

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
            int select = Convert.ToInt32(Console.ReadLine());

            // 상수 선언방법
            const int constNum = 10;
            // 선택에 따른 값 출력
            switch (select)
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