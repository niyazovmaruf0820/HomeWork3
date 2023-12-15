
int n = Convert.ToInt32(Console.ReadLine());
int max=-999999,min=99999,adad;
    
    for(int i=n ; i>0 ; i/=10)
    {
        adad=i%10;
        if(adad > max)max=adad;
        if(adad < min)min=adad;

    }

    System.Console.WriteLine(min + "+" + max + "=" + (max + min));




