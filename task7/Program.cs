int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
IncrementArrayElements(a);
void IncrementArrayElements(int a)
{
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a; i++)
{
   arr[i] += 5;
} 
for (int i = 0; i < a; i++){
    System.Console.WriteLine(arr[i] + " ");
}
}
