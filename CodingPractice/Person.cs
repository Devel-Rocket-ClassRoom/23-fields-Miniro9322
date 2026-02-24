using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    internal class Person
    {
        private string name = "홍길동";
        private const int age = 21;
        private readonly string nickname = "길동이";
        private string[] site = { "네이버", "구글" };

        public void ShowProfile()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"나이: {age}");
            Console.WriteLine($"닉네임: {nickname}");
            Console.WriteLine($"사이트: {string.Join(", ", site)}");
        }
    }
}
