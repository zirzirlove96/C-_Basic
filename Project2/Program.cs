﻿using System;


namespace Project2
{
    class Program
    {
        private Cat cat = new Cat("A",11);
        //기본생성자
        //생성자는 외부에서 호출하기 위해 만들어 준다.

        static void Main(string[] args)
        {

            Program p = new Program();
            p.cat.play();
        }
    }
}
