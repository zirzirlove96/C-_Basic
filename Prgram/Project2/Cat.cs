using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class Cat
        //클래스에도 public, internal로 접근지정자를 지정할 수 있다
        //default는 internal
    {
       
        //default 접근 지정자는 private
        public string name;
        public int age;
        private int happy;

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void play() 
        {
            Console.WriteLine("행복지수 +1");
            happy += 1;
            Console.WriteLine(this.name+"의 행복지수 : " + happy);
        }
    }
}
