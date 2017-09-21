using System;

namespace helloworld_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n,j=0;
            Console.WriteLine("Enter number of strings");
            string NumberOfStrings= Console.ReadLine();
            n=int.Parse(NumberOfStrings);
            string[] array=new string[n];
            string[] newarray=new string[n];
            for(i=0;i<n;i++)
            {
                array[i]=Console.ReadLine();
            }
            Console.WriteLine("Enter the string to be searched");
            string SearchString=Console.ReadLine();
            //Console.WriteLine(SearchString);
            for(i=0;i<n;i++)
            {
                if(array[i]==SearchString)
                {
                Console.WriteLine("String is present and string is {0}",SearchString);
                break;
                }
                else j++;
            }
            if(j==n&&array[j-1]!=SearchString)
             Console.WriteLine("String is not present");
            for(i=0;i<n;i++)
            {
              newarray[i]=array[i];
            }
            Array.Sort(newarray);
            Console.WriteLine("Sorted array size is {0}",NumberOfStrings);
            int size=newarray.Length;
            for(i=0;i<size;i++)
            {
                Console.WriteLine(newarray[i]);
            }
        }
    }
}
