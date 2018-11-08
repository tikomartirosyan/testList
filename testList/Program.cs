using System;

namespace testList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ListTest<int> list = new ListTest<int>(10);
            for (int i = 20; i <= 150; i+=10)
            {
                list.Add(i);
            }
            ListTest<double> list2 = new ListTest<double>(10);
            for (double i = 0.1; i <= 10; i += 0.15)
            {
                list2.Add(i);
            }
            PrintList(list);
            PrintList(list2);
        }
        static void PrintList<T>(ListTest<T> list)
        {
            foreach(T item in list) {Console.WriteLine(item);}
        }
    }
}
