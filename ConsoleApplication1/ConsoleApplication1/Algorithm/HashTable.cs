using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.DataStructure
{
    public class HashTable
    {
        NodeHashtable[] table;
        public HashTable()
        {
            table = new NodeHashtable[1000];
        }
        private int Hash(int key)
        {
            return key.GetHashCode() % 1000;
        }
        void Add(int key, string value)
        {
            int index = Hash(key);
            table[index].Key = key;
            table[index].Value = value;
        }

        string Lookup(int key)
        {
            int index = Hash(key);
            if (table[index] != null)
            {
                return table[index].Value;
            }
            return null;
        }

        void Clear()
        {
            NodeHashtable[] table = new NodeHashtable[1000];
        }

        int Count()
        {
            int count = 0;
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] != null)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
