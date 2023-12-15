
int n = Convert.ToInt32(Console.ReadLine());
int cnt=0;

for(int i = 1 ; i<=n ; i++ )
{
    if(n%i==0)
    {
        System.Console.Write(i + " ");
        cnt++;
        
    }
}
System.Console.WriteLine();
System.Console.WriteLine("Digits = " + cnt);