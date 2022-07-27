using system;
 class pro25
{
     static void main()
    {
        console.write("input  a number(integer): ");
        int n = convert.toint32(console.readline());
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        console.writeline("sum of the digits of the said integer: " + sum);
    }
}