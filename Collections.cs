using System;
using System.Collections.Generic;

namespace HomeWork
{
    internal class Program
    {
        private class ListTask
        {
            public void TaskLoop()
            {
                List<string> list = new List<string>();
                list.Add("Один");
                list.Add("Два");

                Console.WriteLine("Введите строку (или -exit):");
                string s1 = Console.ReadLine();
                if (s1 == "-exit") return;
                list.Add(s1);

                Console.WriteLine("Список:");
                foreach (string s in list)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("Введите строку для середины (или -exit):");
                string s2 = Console.ReadLine();
                if (s2 == "-exit") return;

                int mid = list.Count / 2;
                list.Insert(mid, s2);

                Console.WriteLine("Список теперь:");
                foreach (string s in list)
                {
                    Console.WriteLine(s);
                }
            }
        }

        private class DictionaryTask
        {
            public void TaskLoop()
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();

                Console.WriteLine("Имя:");
                string name = Console.ReadLine();
                if (name == "-exit") return;

                Console.WriteLine("Оценка (2-5):");
                string markStr = Console.ReadLine();
                if (markStr == "-exit") return;

                int mark = int.Parse(markStr);
                if (mark < 2 || mark > 5)
                {
                    Console.WriteLine("Неверная оценка.");
                    return;
                }

                dict[name] = mark;

                Console.WriteLine("Имя для поиска:");
                string search = Console.ReadLine();
                if (search == "-exit") return;

                if (dict.ContainsKey(search))
                {
                    Console.WriteLine("Оценка: " + dict[search]);
                }
                else
                {
                    Console.WriteLine("Не найдено.");
                }
            }
        }

        private class LinkedListTask
        {
            private class Node
            {
                public string Data;
                public Node Next;
                public Node Prev;
                public Node(string data)
                {
                    Data = data;
                }
            }

            public void TaskLoop()
            {
                Node head = null;
                Node tail = null;

                Console.WriteLine("Введите 3 строки:");

                for (int i = 0; i < 3; i++)
                {
                    string s = Console.ReadLine();
                    if (s == "-exit") return;

                    Node n = new Node(s);
                    if (head == null)
                    {
                        head = n;
                        tail = n;
                    }
                    else
                    {
                        tail.Next = n;
                        n.Prev = tail;
                        tail = n;
                    }
                }

                Console.WriteLine("Прямо:");
                Node cur = head;
                while (cur != null)
                {
                    Console.WriteLine(cur.Data);
                    cur = cur.Next;
                }

                Console.WriteLine("Обратно:");
                cur = tail;
                while (cur != null)
                {
                    Console.WriteLine(cur.Data);
                    cur = cur.Prev;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1 - список, 2 - словарь, 3 - двусвязный список");
            string input = Console.ReadLine();

            if (input == "1")
            {
                new ListTask().TaskLoop();
            }
            else if (input == "2")
            {
                new DictionaryTask().TaskLoop();
            }
            else if (input == "3")
            {
                new LinkedListTask().TaskLoop();
            }
            else
            {
                Console.WriteLine("Неверный выбор.");
            }
        }
    }
}