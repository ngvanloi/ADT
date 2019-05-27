using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.DataStructure
{
    public class HashTable
    {
        public static NodeHashtable[] table;
        public HashTable(int size)
        {
            table = new NodeHashtable[size];
        }
        public static int Hash(string key)
        {
            return (key.GetHashCode() % 1000) * -1;
        }
        public static void Add(string key, int value)
        {
            int index = Hash(key);
            table[index].Key = key;
            table[index].Value = value;
        }

        public static string Lookup(string key)
        {
            int index = Hash(key);
            if (table[index] != null)
            {
                return table[index].Value.ToString();
            }
            return null;
        }

        public static void Clear()
        {
            table = new NodeHashtable[1000];
        }

        public static int Count()
        {
            int count = 0;
            foreach (var item in table)
            {
                if (item.Key != null)
                {
                    count++;
                }
            }
            
            return count;
        }

    }
}
