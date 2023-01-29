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

string[] array1 = {"hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer sience"};
string[] array3 = {"Russia", "Denmark", "Kazan"};

ShowArray(array1);
Console.WriteLine();
ShowArray(array2);
Console.WriteLine();
ShowArray(array3);
Console.WriteLine();

Console.Write("Input of maximum element size: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] newArray1 = new string[CountElementLenght(array1, size)];
CopySizeElements(array1, newArray1, size);
ShowArray(newArray1);
Console.WriteLine();

string[] newArray2 = new string[CountElementLenght(array2, size)];
CopySizeElements(array2, newArray2, size);
ShowArray(newArray2);
Console.WriteLine();

string[] newArray3 = new string[CountElementLenght(array3, size)];
CopySizeElements(array3, newArray3, size);
ShowArray(newArray3);
Console.WriteLine();