
int n = Convert.ToInt32(Console.ReadLine());

int odd = 0, even = 0, digit = 0, sum = 0;

for( int i=n; i>0 ; i/=10)
{
    digit+=i%10;
    sum++;
    if(i%2==0)even++;
    if(i%2!=0)odd++;
}

System.Console.WriteLine("Even : " + even);
System.Console.WriteLine("Odd : " + odd);
System.Console.WriteLine("Dogit: " + sum);
System.Console.WriteLine("Sum : " + digit);