using System;

namespace Programe
{
    class Program
    {
        static void Main(string[] args)
        {//.cs파일은 c#를 코딩하는 파일이다.
            //Main함수가 시작되면 이 프로그램이 수행된다.(항상 먼저 실행된다. 운영체제에 의해 호출된다.)
            //using - 시스템안의 툴을 가져다 쓰게 해준다.(라이브러리를 사용하는 것)
            //namespace - namespace안에 내가 만들 프로그램을 짠다.
            Console.WriteLine("Hello World!");
            Console.WriteLine(args[0]+" "+args[1]);

            Console.ReadKey();//console창에 아무키나 누르면 console창이 꺼진다.
            
        }
    }
}
