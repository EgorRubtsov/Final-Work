// Написать программу, которая из имеющегося массива строк 
//выводит массив строк с длиной менее или равнjq 3 символам.



string[] array = { "Russia", "Columbia", "Dominikana", "12", "lem", "-=", "Georgia11" };

PrintArray(array);


int countNewArray = FindCount(array);

Console.Write($"[{String.Join(", ", FillArray(countNewArray))}]");

System.Console.WriteLine();


// -------печатаем и выводим в консоль заданный массив---

void PrintArray(string[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");

    System.Console.WriteLine();
}




// -----определяем размерность нового массива

int FindCount(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

// ----заполняем новый массив---

string[] FillArray(int countNewArray)
{
    string[] array2 = new string[countNewArray];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[k] = array[i];
            k++;
        }
    }
    return array2;
}



// string[] newArray = Array.FindAll(array, word => word.Length <= 3);
// foreach (var word in newArray) Console.Write($"{word}, ");
// System.Console.WriteLine();