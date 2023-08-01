 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal struct List
    {
        public List() { }
        public void LinkedList() 
        {
            List<int> ints = new List<int>();
            ints.Add(4); //avelacnum e listi verjum
            ints.Add(7);
            ints.Add(9);
            ints.Add(5);
            ints.AddRange(new List<int>() { 5,6,5,4,9}); //avelacnum e nor list

            ints.RemoveAt(1); //kjnji 1rd index unecox tivy
            ints.Remove(4); //1in patahac 4y kjnji

            ints.Insert(0, 6); // 0 indexum kavelacni 6 tivy
            Console.WriteLine(ints.IndexOf(5)+" indexum e gtnvum 5 tivy");

            for (int i = 0; i < ints.Count; i++) 
            {
                Console.WriteLine(ints[i]);
            };
        }

        public void Queue()
        {
            Queue<string> patients = new Queue<string>();
            patients.Enqueue("Armine");
            patients.Enqueue("Anna");
            patients.Enqueue("Vahe");
            patients.Enqueue("Narek");

            foreach(string patient in patients)
            {
                Console.WriteLine(patient);
            }

            Console.WriteLine("Now patient " + patients.Dequeue()); //kvercni 1in patientin cuyc kta ev kheracni
            Console.WriteLine("After " +patients.Peek()); //vercnum e hajord patientin bayc chi jnum
            foreach (string patient in patients)
            {
                Console.WriteLine(patient);
            }
        }

        public void Stack()
        {
            Stack<int> ints = new Stack<int>();
            ints.Push(1); //avelacnum e element
            ints.Push(2);          
            ints.Push(3);
            ints.Push(4);
            ints.Push(5);

            while(ints.Count > 0)
            {
                Console.WriteLine(ints.Pop()); //khani ev ktpi hertov elementnery verjic skizb 
            }
        }

        public void Dictionary()
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries.Add("Armenia", "Yerevan"); //armenia key yerevan value
            countries.Add("Rusia", "Moscow");
            countries.Add("Ucraine", "Kiev");


            if (countries.ContainsKey("Armenia"))
            {
                Console.WriteLine(countries["Armenia"]);
            }

            foreach (var country in countries)
            {
            Console.WriteLine("Country " +country.Key+ " City "+country.Value);
            }
        }

        public void HashSet()
        {
            //dicamic, unicue, one type element, kardum e skzbic, krknvox elementnery jnjvum en

            HashSet<string> ints = new HashSet<string>()
            {
                "Anna","Vahan","Vahe","Vahan","Armine", "Lusine"
            };

            ints.Add("Hayk");
            ints.RemoveWhere(x => x.Length != 6); //kjnji bolor elementnery voronq chnen 6 simvol
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
