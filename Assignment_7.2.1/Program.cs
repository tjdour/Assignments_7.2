// Assignment 7.2.1
// Implement merge sort on an unsorted array of numbers.
// Take the array input from user.


Console.WriteLine("Enter array size: ");
int arrSize = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[arrSize];


for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Enter value for index [{i}]: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nOriginal array:");
PrintArray(numbers);


MergeSort(numbers, 0, numbers.Length - 1);

Console.WriteLine("\nSorted array:");
PrintArray(numbers);


void Merge(int[] array, int left, int middle, int right)
{
    int leftSize = middle - left + 1;
    int rightSize = right - middle;

    int[] leftArray = new int[leftSize];
    int[] rightArray = new int[rightSize];

    for (int i = 0; i < leftSize; i++)
    {
        leftArray[i] = array[left + i];
    }

    for (int j = 0; j < rightSize; j++)
    {
        rightArray[j] = array[middle + 1 + j];
    }

    int leftIndex = 0;
    int rightIndex = 0;
    int arrayIndex = left;

    while (leftIndex < leftSize && rightIndex < rightSize)
    {
        if (leftArray[leftIndex] <= rightArray[rightIndex])
        {
            array[arrayIndex] = leftArray[leftIndex];
            leftIndex++;
        }
        else
        {
            array[arrayIndex] = rightArray[rightIndex];
            rightIndex++;
        }

        arrayIndex++;
    }

    while (leftIndex < leftSize)
    {
        array[arrayIndex] = leftArray[leftIndex];

        leftIndex++;
        arrayIndex++;
    }

    while (rightIndex < rightSize)
    {
        array[arrayIndex] = rightArray[rightIndex];

        rightIndex++;
        arrayIndex++;
    }
}

void MergeSort(int[] array, int left, int right)
{
    if (left < right)
    {
        int middle = (left + right) / 2;

        MergeSort(array, left, middle);
        MergeSort(array, middle + 1, right);

        Merge(array, left, middle, right);
    }
}


void PrintArray(int[] array)
{
    foreach (int num in array)
    {
        Console.Write(num + " ");
    }

    Console.WriteLine();
}