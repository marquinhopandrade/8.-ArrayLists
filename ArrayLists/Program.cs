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
            myArrayList.Add(25);
            myArrayList.Add("hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);

            //delete element with specific entry from the arraylist
            myArrayList.Remove(13);
        }
    }
}
