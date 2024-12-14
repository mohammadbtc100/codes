//create arrays
int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10};
int[] numbers2 = new int[10];
//set values of second array
for (int i = 0; i < numbers1.Length; i++) {
    numbers2[i] = numbers1[i] * 10;
}
//print first array
for (int i = 0; i < numbers1.Length; i++) { 
    Console.Write(numbers1[i]+" ");
}
//print second array
Console.WriteLine();
for (int i = 0; i < numbers2.Length; i++)
{
    Console.Write(numbers2[i]+" ");
}
