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
    }
}
