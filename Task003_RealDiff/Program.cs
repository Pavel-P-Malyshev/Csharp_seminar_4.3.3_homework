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
void PrintArray (double[] col)
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
    double min_el=0;
    double max_el=0;

    for(int i=0;i<array.Length;i++)
    {
        array[i]=((min+max*2.2+i)/(min+max*3.3-i))*100;
        if(i==0) 
        {
             min_el=array[i];
             max_el=array[i];   
        }
        else
        {
            if (array[i]>max_el) max_el=array[i];
            if (array[i]<min_el) min_el=array[i];
        }

    }

      
      PrintArray(array);
    
       

    return max_el-min_el;


}


double diff=RandomMinMax(Prompt("enter array size: "),Prompt("Enter min threshold: "), Prompt("Enter max threshold: "));
System.Console.Write ($" difference between max and min array elements is: {diff}");





