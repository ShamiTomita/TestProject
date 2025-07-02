using System;
// Practicing Sorting Algorithms 

// Quick Sort 

public class SortingAlgorithms
{
    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(arr, low, high);

            QuickSort(arr, low, pivot - 1);
            QuickSort(arr, pivot + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];

        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, high);
        return i + 1;
    }

    public static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }













    // Quick Sort is a sorting algorithm that chooses a pivot index in an array
    // and then moves smaller items to the left of the pivot. It recursively divides the array 
    // into 2 partitions 
    // Best & Average Case Runtime is O(n log(n))
    // Worst Case (if already sorted ) if O(n2)
    // Quick Sort takes the array/partition to be sorted as well as a start and end index
    public static void ShamiQuickSort(int[] array, int start, int end)
    {
        // Base Case, if the end index of our array/partition is less than or equal to start 
        // return. 
        if (end <= start) return;

        // we need to sort the array and return the pivot index
        int pivot = Partition(array, start, end);

        // now that we have our pivot, we can pass it into our Recursive function, making sure 
        // not to include the pivot as the pivot should be in its proper place at this point 
        ShamiQuickSort(array, start, pivot - 1);
        ShamiQuickSort(array, pivot + 1, end);
    } 

    // Partition will sort the array and then return the pivot
    public static int Partiton(int[] array, int start, int end)
    {

        // for this helper method, we designate a new pivot 
        int pivot = array[end];
        int i = start - 1;
        for (int j = start; j <= end - 1; j++)
        {
            // any element smaller than our pivot 
            // should STAY on the left 
            // any element larger than our pivot
            // should Go to the Right 
            if (array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        i++;
        int t = array[i];
        array[i] = array[end];
        array[end] = t;
        return i;
    }















    public static void Main()
    {
        int[] quickSortArray = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine($"Before: {string.Join(", ", quickSortArray)}");
        ShamiQuickSort(quickSortArray, 0, quickSortArray.Length - 1);
        Console.WriteLine($"After: {string.Join(", ", quickSortArray)}");
    }
}

