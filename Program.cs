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

void CopySizeElements(string[] array1, string[] array2, int size)
{
    int j = 0;
    for(int i = 0; i < array1.Length; i++)
        if(array1[i].Length <= size)
        {
            array2[j] = array1[i];
            j++;
        }
}
