using system;


class pro16
{
    static void main()
    {
        string str;

        console.write("input a string : ");
        str = console.readline();
        if (str.length >= 1)
        {
            var s = str.substring(0, 1);
            console.writeline(s + str + s);
        }
    }
}