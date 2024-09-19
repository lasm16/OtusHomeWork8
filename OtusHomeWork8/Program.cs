using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace OtusHomeWork8
{
    internal class Program
    {
        static Stopwatch stopwatch = new Stopwatch();
        static Random random = new Random();

        static void Main(string[] args)
        {
            var list = FillList();
            var arrayList = FillArrayList();
            var linkedList = FillLinkedList();
            Console.WriteLine();

            FindElementInList(list);
            FindElementInArrayList(arrayList);
            FindElementInLinkedList(linkedList);
            Console.WriteLine();

            DevideBy777(list);
            DevideBy777(arrayList);
            DevideBy777(linkedList);
        }

        private static List<int> FillList()
        {
            stopwatch.Start();
            var list = new List<int>();
            for (var i = 0; i < 1000000; i++)
            {
                list.Add(random.Next());
            }
            stopwatch.Stop();
            Console.WriteLine("Заполнение List: " + stopwatch.Elapsed.ToString());
            return list;
        }

        private static void FindElementInList(List<int> list)
        {
            stopwatch.Start();
            var element = list.ElementAt(496753);
            stopwatch.Stop();
            Console.WriteLine("Поиск 496753 элемента в List: " + stopwatch.Elapsed.ToString() + $" Элемент = {element}");
        }

        private static ArrayList FillArrayList()
        {
            stopwatch.Start();
            var arrayList = new ArrayList();
            for (var i = 0; i < 1000000; i++)
            {
                arrayList.Add(random.Next());
            }
            stopwatch.Stop();
            Console.WriteLine("Заполнение ArrayList: " + stopwatch.Elapsed.ToString());
            return arrayList;
        }

        private static void FindElementInArrayList(ArrayList arrayList)
        {
            stopwatch.Start();
            var element = arrayList[496753];
            stopwatch.Stop();
            Console.WriteLine("Поиск 496753 элемента в ArrayList: " + stopwatch.Elapsed.ToString() + $" Элемент = {element}");
        }

        private static LinkedList<int> FillLinkedList()
        {
            stopwatch.Start();
            var linkedList = new LinkedList<int>();
            for (var i = 0; i < 1000000; i++)
            {
                linkedList.AddLast(random.Next());
            }
            stopwatch.Stop();
            Console.WriteLine("Заполнение LinkedList: " + stopwatch.Elapsed.ToString());
            return linkedList;
        }

        private static void FindElementInLinkedList(LinkedList<int> linkedList)
        {
            stopwatch.Start();
            var element = linkedList.ElementAt(496753);
            stopwatch.Stop();
            Console.WriteLine("Поиск 496753 элемента в LinkedList: " + stopwatch.Elapsed.ToString() + $" Элемент = {element}");
        }

        private static void DevideBy777(List<int> list)
        {
            stopwatch.Start();
            foreach (var item in list)
            {
                if (item % 777 == 0)
                {
                    Console.WriteLine("Элемент из List, который делится без остатка на 777: " + item);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Поиск элементов, которые делится на 777 без остатка в List: " + stopwatch.Elapsed.ToString());
        }

        private static void DevideBy777(ArrayList arrayList)
        {
            stopwatch.Start();
            foreach (var item in arrayList)
            {
                if ((int)item % 777 == 0)
                {
                    Console.WriteLine("Элемент из ArrayList, который делится без остатка на 777: " + item);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Поиск элементов, которые делится на 777 без остатка в ArrayList: " + stopwatch.Elapsed.ToString());
        }

        private static void DevideBy777(LinkedList<int> linkedList)
        {
            stopwatch.Start();
            foreach (var item in linkedList)
            {
                if (item % 777 == 0)
                {
                    Console.WriteLine("Элемент из LinkedList, который делится без остатка на 777: " + item);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Поиск элементов, которые делится на 777 без остатка в LinkedList: " + stopwatch.Elapsed.ToString());
        }
    }
}
