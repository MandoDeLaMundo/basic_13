using System;

namespace basic_13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int [] numbers = {3, 1, 52, 10, -5, 25};
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(numbers);
            // FindMax(numbers);
            // GetAverage(numbers);
            // OddArray();
            // GreaterThanY(numbers, 11);
            // SquareArrayValues(numbers);
            // EliminateNegatives(numbers);
            // MinMaxAverage(numbers);
            // ShiftValues(numbers);
            NumToString(numbers);
        }


// 1
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i < 256; i++)
                {
                    Console.WriteLine(i);
                }
        }

// 2
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i = 1; i < 256; i++)
                if (i % 2 == 1) {
                    Console.WriteLine(i);
                }
        }

// 3
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3

            int sum = 0;
            for (int i = 1; i < 256; i++){
                sum = sum + i;
                Console.WriteLine(sum);
            }
        }

// 4
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            foreach (var num in numbers){
                Console.WriteLine(num);
            }
        }

// 5
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int currentMax = Int32.MinValue;
            foreach (var num in numbers){
                if (currentMax < num){
                    currentMax = num;
                }
            }
            Console.WriteLine(currentMax);
            return currentMax;
        }

// 6
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            foreach (var num in numbers)
                sum += num;

            float average = (float)sum / numbers.Length;
            Console.WriteLine(average);
        }

// 7
        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            int size = (255/2) + 1;

            int[] newArray = new int[size];

            int i = 0;

            for (int num = 1; num <= 255; num += 2){
                newArray[i] = num;
                i++;
            }
            return newArray;
        }

// 8
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int x = 0;
            foreach (var num in numbers){
                if (num > y){
                    x++;
                }
            }
            Console.WriteLine(x);
            return x;
        }

// 9
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int i = 0; i < numbers.Length; i++){
                numbers[i] = numbers[i] * numbers[i];
                Console.WriteLine(numbers[i]);
            }
        }

// 10
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++){
                if (numbers[i] < 0){
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
        }

// 11
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            FindMax(numbers);

            int currentMin = Int32.MaxValue;
            foreach (var num in numbers){
                if (currentMin > num){
                    currentMin = num;
                }
            }
            Console.WriteLine(currentMin);

            GetAverage(numbers);
        }

// 12
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (int i = 0; i < numbers.Length - 1; i++){
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length-1] = 0;
        }

// 13
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] Arr2 = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++){
                if (numbers[i] < 0){
                    Arr2[i] = "Dojo";
                    Console.WriteLine(Arr2[i]);
                }
                else{
                    Arr2[i] = numbers[i];
                    Console.WriteLine(Arr2[i]);
                }
            }
            return Arr2;
        }

    }
}
