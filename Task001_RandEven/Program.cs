/*
Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в 
массиве.
[345, 897, 568, 234] -> 2

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


int RandomEvenNum(int size, int min, int max)
{
    int[] array=new int[size];
    int answer=0;
    Random rnd=new Random();

    for(int i=0;i<array.Length;i++)
    {
        array[i]=rnd.Next(min,max+1);
        if(array[i]%2==0) answer++;
  
    }


    PrintArray(array);
       

    return answer;


}


int EvenNum=RandomEvenNum(Prompt("enter array size: "),Prompt("Enter min threshold: "), Prompt("Enter max threshold: "));
System.Console.Write ($" number of even values in array is: {EvenNum}");





