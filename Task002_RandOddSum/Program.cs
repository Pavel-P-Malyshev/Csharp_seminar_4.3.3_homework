/*
Задача 2: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 67] -> 0

*/





int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

//распечатка массива
void PrintArray (int[] col)
{

    int count=col.Length;
    int position=0;

    Console.Write("[ ");
    while(position<count) 
    {
        if(position==count-1)  {Console.Write($"{col[position]}");}
        else {Console.Write($"{col[position]}, ");}
        
        position++;
    }
    Console.WriteLine("] ");

}


int RandomOddSum(int size, int min, int max)
{
    int[] array=new int[size];
    int answer=0;
    Random rnd=new Random();

    for(int i=0;i<array.Length;i++)
    {
        array[i]=rnd.Next(min,max+1);
        if(i%2>0) answer+=array[i];
  
    }


    PrintArray(array);
       

    return answer;


}


int OddSum=RandomOddSum(Prompt("enter array size: "),Prompt("Enter min threshold: "), Prompt("Enter max threshold: "));
System.Console.Write ($" sum of odd-placed elements: {OddSum}");





