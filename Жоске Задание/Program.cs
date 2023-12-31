﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Жоске_Задание
{
    internal class IntArrayList
    {
        private List<int> storage;
        private int count;
        private int capacity;
        private readonly int defaultSize = 2;
        public int Count
        {
            get => storage.Count;
        }
        public int Capacity
        {
            get => storage.Capacity;
        }
        public int Index(int index)
        {
            return storage[index];
        }
        public IntArrayList()
        {
            storage= new List<int>(defaultSize);
        }
        public IntArrayList(int capacity)
        {
            this.capacity = capacity;
            storage = new List<int>(this.capacity);
        }
        public void PushBack(int number)
        {
            storage.Add(number);
        }
        public void PopBack()
        {
            storage.RemoveAt(storage.Count - 1);
        }
        public void Clear()
        {
            storage.Clear();
        }
        //public bool TryInsert(int index, int element)
        //{
        //    try
        //    {
        //        storage.Insert(index, element);
        //    }
        //    catch (ArgumentOutOfRangeException)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        public int Find(int item)
        {
            int low = 0;
            int high = storage.Count - 1;
            int guess;
            int mid;
            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = this.storage[mid];
                if (guess == item)
                {
                    return mid;
                }
                if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}