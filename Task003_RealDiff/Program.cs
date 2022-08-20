/*
Задача 3: Задайте массив вещественных чисел. Найдите 
разницу между максимальным и минимальным 
элементов массива.
[3, 7.4, 22.3, 2, 78] -> 76

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


double RandomMinMax(int size, int min, int max)
{
    double[] array=new double[size];
    double min=0;
    double max=0;
    Random rnd=new Random();

    for(int i=0;i<array.Length;i++)
    {
        array[i]=(min+min*0.2+i)/(max+max*0.3-i);
  
    }

     double min=array[0];
    double max=array[0];


    PrintArray(array);
       

    return answer;


}


int OddSum=RandomOddSum(Prompt("enter array size: "),Prompt("Enter min threshold: "), Prompt("Enter max threshold: "));
System.Console.Write ($" sum of odd-placed elements: {OddSum}");





