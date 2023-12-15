
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

int min = a;

if( b < min )min = b;
if( c < min )min = c;
if( d < min )min = d;

System.Console.WriteLine(min);
