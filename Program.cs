#pragma warning disable IDE0051, IDE0060
using System;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //문자열 변수
            //데이터타입 변수명 = 초깃값;
            // = 대입연산자
            string userName = "Zack";
            Console.WriteLine(userName);

            //문자열 + 문자열
            Console.WriteLine("Hello " + userName + "!");

            //문자열 보간 $
            Console.WriteLine($"Hello {userName}! , Level={20}");

            string message = "    Zack    ";
            Console.WriteLine($"[{message}]"); //  [    Zack    ]

            //Trim 공백을 제거
            Console.WriteLine($"[{message.Trim()}]");

            //ToUpper() , ToLower()
            Console.WriteLine($"{message.ToUpper()}");
            */

            //키보드로 문자열을 입력
            /*
            Console.Write("닉네임을 입력하세요:");
            string nickName = Console.ReadLine();

            Console.WriteLine($"닉네임은 {nickName}");
            */
            //Cal01(2 , 12);
            //Cal02();
            //Cal03();
            //Cal04();
            //CalSquare();
            //Cal05();
            //Cal06();
            //Cal07();
            //Cal08();
            //DrawStar();
            Cal09();
        }

        //함수의 정의
        //리턴타입 함수명(매개변수0, 매개변수1, ...)
        //매개변수 정의
        // 데이터타입 매개변수명, 
        static void Cal01(int _a, int _b)
        {
            //정수형 변수의 선언과 초기값
            //변수타입 변수명 = 초깃값;
            int a = _a;
            int b = _b;
            int c = a + b;

            Console.WriteLine($"{a} + {b} = {c}");

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"Integer's Max = {max:#,##0} , Min = {min:#,##0}");
        }

        //타입 캐스팅 (Type Casting)
        /*
            명시적 타입 캐스팅
            암시적 타입 캐스팅
        */
        static void Cal02()
        {
            int a = 5;
            int b = 10;
            float c = (float) a / (float) b; // 5/10 = 0   , (float) 5 / (float) 10 = 5.0f / 10.0f = 0.5f
            Console.WriteLine($"{a} / {b} = {c}");
            Console.WriteLine("User Level = " + 10);

            int d = 2;
            int value = a + (b * d); 
            Console.WriteLine($"{a} + ({b} * {d}) = {value}");
        }

        //실수형 데이터 타입
        /*
            float   4byte 32bit f/F
            double  8byte       d/D
            decimal 16byte      m/M   
        */
        static void Cal03()
        {
            float damage = 10.0f; //10.0F
            double xp    = 20000.0d; //20000.0D
            decimal coin = 1000000.0m; //M

            double a = 1.0d;
            double b = 3.0d;
            Console.WriteLine(a / b);

            decimal c = 1.0m;
            decimal d = 3.0m;
            Console.WriteLine(c / d);
        }
    
        //상수 Constant
        // 읽기 전용 변수
        /*
            const    : 컴파일 타입 상수
            readonly : 런타임 타입 상수 (함수의 생성자에서 값 결정)
        */
        const float PI = 3.14f;
        readonly int INIT_LEVEL = 1;

        static void Cal04()
        {
            //원의 면적 : PI * r ^ 2
            float radius = 2.0f;
            //double circleArea = PI * (radius * radius);
            double circleArea = PI * Math.Pow(radius, 2);
            Console.WriteLine($"원의 면적 = {circleArea}");
        }


        /*
        사각형의 폭과 높이를 입력받아서 면적을 계산한 후 콘솔에 출력한다.

        1. "사각형의 폭을 입력하세요." 문자열 출력
        2. 값을 입력받아서 폭 변수에 저장한다.
        3. "사각형의 높이를 입력하세요." 문자열을 출력
        4. 값을 입력받아서 높이 변수에 저장한다.
        5. 폭과 높이 변수값을 서로 곱한 후 출력한다.
        */
        static void CalSquare()
        {
            Console.WriteLine("사각형의 폭을 입력하세요.");
            string width = Console.ReadLine();
            Console.WriteLine("사각형의 높이를 입력하세요>");
            string height = Console.ReadLine();

            float area = float.Parse(width) * float.Parse(height);
            Console.WriteLine($"사각형의 면적 {width} * {height} = {area}");
        }
        //String -> Float
        // float.Parse(string)
        // int.Parse(string)

        //static readonly int MAX_PLAYERS = 10;

        static void Cal05()
        {
            const int MAX_PLAYERS = 10;

            Console.Write("입장가능한 플레이어 수?");
            string strNum = Console.ReadLine();
            int maxPlayers = int.Parse(strNum);

            if (maxPlayers >= MAX_PLAYERS)
            {
                Console.WriteLine("Exceed Max Player !!!");
            }
            else
            {
                Console.WriteLine($"Entered player count {maxPlayers}");
            }
        }

        //3항 연산자
        /* 
            (condition) ? value1 : value2;
        */
        static void Cal06()
        {
            int a = 3;
            string str = (a % 2 == 0) ? "짝수" : "홀수";
            Console.WriteLine(str);

            //비교연산자
            if (a % 2 == 0)
            {      
                str = "짝수";    
            }
            else
            {
                str = "홀수";
            }
       }

        //Switch-case
       static void Cal07()
       {
           /*
                switch([value])
                {
                    case [value1]:
                        [logic];
                        break;
                    case [value2]:
                        [logic2];
                        break;
                }
           */

           Console.Write("Enter number (1,2,3):");
           string num = Console.ReadLine();

           switch (int.Parse(num))
           {
               case 1:
                    Console.WriteLine("Num = 1");
                    break;
               case 2:
                    Console.WriteLine("Num = 2");
                    break;                    
               case 3:
                    Console.WriteLine("Num = 3");
                    break;                    
           }
       }

       //반복문 
       /*
            for
            foreach
            while
            do/while

            for(init_value ; condition; increase_value)
            {
                Logic;
            }
        */
        static void Cal08()
        {
            for (int i=1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i=0; i<10; i++)
            {
                Console.Write("*");
            }

            for (int i=2 ; i<10; i++)
            {
                for (int j=1; j<10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i*j}");
                }
                Console.WriteLine("");
            }
        }

        static void DrawStar()
        {
            /*
            연습문제
            *
            **
            ***
            ****
            *****
            
            */
            for (int i=0; i < 6; i++)
            {
                for(int j=0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    
        //foreach 구문
        static void Cal09()
        {
            //배열
            /*
                items[0] = "SWORD";
                items[1] = "HP";
                items[2] = "POWER";
            */
            string[] items = new string[3] {"SWORD", "HP", "POWER"};


            for(int i=0; i<items.Length; i++)
            {
                Console.WriteLine($"items[{i}] = {items[i]}");
            }
        }
    }
}
