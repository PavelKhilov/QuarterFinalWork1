void ShowArray(string[] array)
{
 for(int i = 0; i < array.Length; i++)
    Console.Write('"' + array[i] + '"' + " ");
}

int CountElementLenght(string[] array, int length)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= length)
            count++;
    return count;
}
