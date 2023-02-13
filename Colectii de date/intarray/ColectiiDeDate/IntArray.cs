﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ColectiiDeDate
{
    public class IntArray
    {
        private int[] array;

	public IntArray()
        {
            array = new int[0];
        }

        public void Add(int element)
        {
            Insert(array.Length, element);
        }

        public int Count()
        {
            return array.Count();
        }

        public int Element(int index)
        {
            return array.ElementAt(index);
        }

        public void SetElement(int index, int element)
        {
            array.SetValue(element, index);
        }

        public bool Contains(int element)
        {
            return array.Contains(element);
        }

        public int IndexOf(int element)
        {
            return Array.IndexOf(array, element);
        }

        public void Insert(int index, int element)
        {
            for (int i = array.Length; i > index; i--)
            {
                array[i] = array[i - 1];
            }

            Array.Resize(ref array, array.Length + 1);

            array[index] = element;
        }

        public void Clear()
        {
            Array.Clear(array, 0, array.Length);
        }

        public void Remove(int element)
        {
            RemoveAt(IndexOf(element));
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < array.Length; i++)
            {
                array[i] = array[i + 1];
            }

            Array.Resize(ref array, array.Length - 1);
        }

    }
}
