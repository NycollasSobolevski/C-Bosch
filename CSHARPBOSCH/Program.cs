using  System;
Console.WriteLine("Hello World!");


// int i  = 3;
// if (i<10)
// {
//     Console.WriteLine(i);
// }
// else if (i<15)
// {
//     Console.WriteLine("Muito Forte");
// }
// else
// {
//     Console.WriteLine()
// }


//                          Switch/case
// int i = 3;
// switch (i)
// {
//     case 3:
//         Console.WriteLine(3);
//         goto case 5;
//     case 4:
//         Console.WriteLine(4);
//         break;
//     case 5:
//         Console.WriteLine("Bom dia!");
//         break;
//     default:
//         Console.WriteLine("Nao sei");
//         break;
// }

//                          while
// int i = 3;
// while (i<10)
// {
//     Console.WriteLine("oi");
//     i++;
// }


//                           FOR
// for (int i=0; i<10; i++)
// {
//     Console.WriteLine("oi!");
// }



// int[] arr = new int[100];
// for (int i=0; i<arr.Length;i++)
// {
//     arr[i] = 1;
// }

// foreach (int n in arr)
// {
//     Console.WriteLine(n):
// }

//##################################################################################

// MERGE SORT
int[] arr = new int[]
{8,4,2,3,9,12,11,1};



mergesort(arr);
foreach(var x in arr)
{
    Console.Write($"{x}, ");
}


void mergesort(int[] arr)
{
    int e = arr.Length;
    int [] arraux = new int [e];
    mergesortrec(arr, arraux, 0, e);
}

void mergesortrec(int[] arr,int[] arraux, int s, int e)
{
    if (e - s < 2)
        return;
    int p =  (s + e)/2;
    mergesortrec(arr, arraux, s, p);
    mergesortrec(arr, arraux, p, e);
    merge(arr,arraux,s,p,e);
}

void merge(int[] arr, int[]arraux,int s, int p, int e)
{
    int i = s, j = p, k = s;
    while(i < p && j < e)
    {
        if (arr[i] < arr[j])
        {
            arraux[k] = arr[i];
            i++;
            k++;
        }
        else
        {
            arraux[k] = arr[j];
            j++;
            k++;
        }
    }

    while(i<p)
    {
        arraux[k] = arr[i];
        i++;
        k++;
    }

    while(j<e)
    {
        arraux[k] = arr[j];
        j++;
        k++;
    }
    for (int t = s; t<e; t++)
    {
        arr[t] = arraux[t];
    }
}
