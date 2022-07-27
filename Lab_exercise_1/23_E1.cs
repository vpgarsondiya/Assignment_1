using system;

 class pro23
{
     static void main()
    {
        console.writeline("odd numbers from 1 to 99. prints one number per line.");
        for (int n = 1; n < (99 + 1); n++)
        {
            if (n % 2 != 0)
            {
                console.writeline(n.tostring());
            }
        }
    }
}