using System;
using MyLibrary;

namespace ConsoleApp//Студент Корнилов Артем
{
    class Program
    {
        static void Main(string[] args)//Студент Корнилов Артем
        {
            Person person = new Person("123 Основная улица");//Студент Корнилов Артем

            person.AddHobby(new Hobby("Чтение", "Мне нравится читать книги"));
            person.AddHobby(new Hobby("Спорт", "Я люблю заниматься спортом"));
            person.AddHobby(new Hobby("Кулинария", "Мне нравится готовить вкусные блюда."));//Студент Корнилов Артем

            person.ShowAll();

            person.Hobbies.Sort();
            person.ShowAll();

            Console.ReadLine();//Студент Корнилов Артем
        }
    }
}
