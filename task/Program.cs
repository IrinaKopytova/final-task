
Console.WriteLine("Введите количество значений в массиве:");
int countArray = Convert.ToInt32(Console.ReadLine());

string [] Array1 = new string [countArray];
 
 string [] FillArray (string [] array)
 {
	for (int i = 0; i < countArray; i++)
	{
		Console.WriteLine($"Введите {i+1} значение:");
		array[i] = Console.ReadLine();
	}
	return array;
}

string [] SortArray (string [] array)
{
	int count = 0;
	string arrayValue = string.Empty;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3) count++;
	}

	string [] Array2 = new string [count];
	int index = 0;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3)
		{
			Array2[index] = array[i];
			index++;
		}
	}
	return Array2;
}

void PrintArray (string [] array)
{
	if (array.Length == 0) 
        Console.WriteLine("Массив не имеет значений!");
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write($"  [{array[i]}]");
		}
}

FillArray(Array1);

string [] Array2 = SortArray(Array1);

Console.WriteLine("Первоначальный массив:");
PrintArray(Array1);

Console.WriteLine("\nМассив значений с длинной (<) либо = (3) символа:");
PrintArray(Array2);
