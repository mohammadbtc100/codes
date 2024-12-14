int n = 5,sum=0;
//get random numbers
Random rnd = new Random();
//create arrays
int[] array = new int[n];
for (int i = 0; i < n; i++) {
    array[i] = rnd.Next(20);
    sum=sum+array[i]; //sum+=array[i];
    Console.Write(array[i]+" ");
}
Console.WriteLine("\nSum is "+sum);
Console.WriteLine("Avg is "+(sum/n));
Console.ReadKey();