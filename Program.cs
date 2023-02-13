string[] firstArray = new string[5] {"Hello","World","45",":-)","(.)(.)"};
string[] secondArrray = new string[firstArray.Length];




void Sort(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for( int i = 0; i< firstArray.Length; i++)
    {
        if(firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}