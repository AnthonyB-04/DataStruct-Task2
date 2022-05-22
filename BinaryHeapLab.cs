﻿using System;
using Task2.BinaryHeap;

namespace Task2
{
    public class BinaryHeapLab : ILab
    {
        private readonly BinaryHeap.BinaryHeap _binaryHeap = new(15);

        void ILab.Start()
        {
            Console.WriteLine("3. Binary heap");
            _binaryHeap.FillWithRandom();
            _binaryHeap.Show();
            _binaryHeap.PopMin();
            _binaryHeap.Show();
        }
    }

}
