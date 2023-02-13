using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring an ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            //Declaring an ArrayList with a defined amount of object
            ArrayList myArrayList2 = new ArrayList(100);
            myArrayList.Add(25); //0
            myArrayList.Add("hello"); //1
            myArrayList.Add(13.37); //2
            myArrayList.Add(13);  //3
            myArrayList.Add(128); //4
            myArrayList.Add(25.3); //5
            myArrayList.Add(13); //6

            //delete element with specific entry from the arraylist
            myArrayList.Remove(13);
            //delete element at specific position or index
            myArrayList.RemoveAt(0);
            /*delete element at specific range (a partir de qual posição deve remover, quantos numeros a partir da posição)
            no caso RemoveRange(4,2), a partir da posição 3 (13) serão removidos (2) dois valores a frente (no caso o 128 e o 25.3) */
            myArrayList.RemoveRange(4,2);
        }
    }
}
