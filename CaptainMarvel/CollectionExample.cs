using System;
using System.Collections;

namespace CaptainMarvel
{
    class CollectionExample
    {
        public void arrayListExample() {
            ArrayList a1 = new ArrayList();
            a1.Add(5);
            a1.Add(9);
            a1.Add(12);
            a1.AddRange(new int[2] { 15, 23 });



            Console.WriteLine(a1[2]);
            Console.WriteLine("=========================");
            foreach (var element in a1) {
                Console.WriteLine(element);
            }
            
        }


        public void hashTableExample() {
            Hashtable h1 = new Hashtable();
            h1.Add("name", "sulav");
            h1.Add("age", new int[5] {  2, 3, 5, 7, 9 });

            Console.WriteLine(h1["name"]);
            // convert to int[] to access the element via a[2]
            // can not be done by default
            Console.WriteLine(((int[])h1["age"])[2]);
        }
    }
}
