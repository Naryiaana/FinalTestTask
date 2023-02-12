string[] CreateRandomArray()
{
    Console.Write("Input the size of an array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
        {
        Console.Write("Input a word: ");
        array[i] = Console.ReadLine();
        }

    return array;   
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] CutArray(string[] array)
{
    string[] newArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
        else {
            newArray[i] = String.Empty;
            }
    }

    return newArray;
}

string[] stringArray = CreateRandomArray();
Console.Write("Your initial array of strings looks like this: ");
ShowArray(stringArray);

string[] newStringArray = CutArray(stringArray);
Console.Write("Your array of strings with words that are 3 symbols or shorter: ");
ShowArray(newStringArray);
