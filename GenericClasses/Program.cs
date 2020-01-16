using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class ListOfObjects<T>
    {
        private T[] theList;
        private int noOfElements = 10;
        private int nextIndex;
        public ListOfObjects()
        {
            theList = new T[noOfElements];
            nextIndex = 0;
        }
        public void AddObject(T obj)
        {
            if(nextIndex >= theList.Length)
            {
                Console.WriteLine("Array length exceeded");
                return;
            }
            theList[nextIndex] = obj;
            nextIndex++;
        }
        public T GetObject(int index)
        {
            if (index >= theList.Length)
            {
                Console.WriteLine("Array index too high");
                return default(T);
            }
            return theList[index];
        }
    }
    /*    public class ListOfStrings
        {
            private string[] theArray;
            private int noOfElements = 10;
            private int nextIndex;
            public void ArrayOfStrings()
            {
                theArray = new string[noOfElements];
                nextIndex = 0;
            }
            public void AddString(string s)
            {
                theArray[nextIndex] = s;
                nextIndex++;
            }
            public string GetString(int index)
            {
                return theArray[index];
            }
        }*/

    class Program
    {
    static void Main(string[] args)
    {
            ListOfObjects<object> myListOfObjects = new ListOfObjects<object>();
            myListOfObjects.AddObject("Woop");
            myListOfObjects.AddObject("AAAAAA");
            myListOfObjects.AddObject("AAAAAA");
            myListOfObjects.AddObject("AAAAAA");
            myListOfObjects.AddObject("AAAAAA");
            myListOfObjects.AddObject("AAAAAA");
            myListOfObjects.AddObject("AAAAAA");
            myListOfObjects.AddObject("AAAAAA");
            myListOfObjects.AddObject("AAAAAA");
            myListOfObjects.AddObject("AAAAAA");
            myListOfObjects.AddObject("AAAAAA");
            myListOfObjects.AddObject("AAAAAA");
            myListOfObjects.AddObject("AAAAAA");
            Console.WriteLine(myListOfObjects.GetObject(3));
            Console.WriteLine(myListOfObjects.GetObject(10));
            Console.WriteLine(myListOfObjects.GetObject(5));
            Console.WriteLine(myListOfObjects.GetObject(11));
            Console.ReadKey();

        }
    }
}
