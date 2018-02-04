using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Appz\VS\gyver\Test.txt";
            //List<string> lines = File.ReadAllLines(filePath).ToList();
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //lines.Add("안녕하세요 ,라인을 ,추가했습니다.");
            //File.WriteAllLines(filePath, lines);

            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Url = entries[2];

                people.Add(newPerson);
            }

            Console.WriteLine("텍스트파일에서 읽어옴");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}: {person.Url}");
            }

            people.Add(new Person { FirstName = "우리별", LastName = "강아지", Url = "또잔다" });
            List<string> output = new List<string>();
            foreach (var person in people)
            {
                output.Add($"{person.FirstName},{person.LastName},{person.Url}");
            }
            Console.WriteLine("저장");
            File.WriteAllLines(filePath, output);
            Console.WriteLine("모두 저장되었음");
            Console.ReadLine();
        }
    }
}
