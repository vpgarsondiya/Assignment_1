using system;
 class pro244
{
     static void main()
    {
        console.writeline("\nsum of the first 500 prime numbers: ");
        long sum = 0;
        int ctr = 0;
        int n = 2;
        while (ctr < 500)
        {
            if (isprime(n))
            {
                sum += n;
                ctr++;
            }
            n++;
        }

        console.writeline(sum.tostring());

    }
    public static bool isprime(int n)
    {
        int x = (int)math.floor(math.sqrt(n));

        if (n == 1) return false;
        if (n == 2) return true;

        for (int i = 2; i <= x; ++i)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}
