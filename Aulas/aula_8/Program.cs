using System.Collections;
using System;
using System.Collections.Generic;

// // ################### LISTA GENERICA ##################
// LinkedList<int> list = new LinkedList<int>();
// list.Add(1);
// list.Add(2);
// list.Add(3);
// for (int i=0; i < list.Count; i++)
// {
//     Console.WriteLine(list[i]);
// }
//#########################################################


double num = 81.0;
num.Sqrt().Sqrt().Print();


List<int> list = new List<int>();
list.Add(10);
list.Add(11);
list.Add(12);
list.Add(13);
list.Add(14);
list.Add(15);

for (int i = 0; i< list.Count; i++)
{
    Console.WriteLine(list[i]);
}


list
    .Skip(2)
    .Take(3)
    .ToStringList()
    .Concat()
    .Print();

