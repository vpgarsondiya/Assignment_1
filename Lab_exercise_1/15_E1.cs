using system;


 class pro15
{
    static void main()
    {
        console.writeline(remove_char("atmiya university", 1));
        console.writeline(remove_char("atmiya university", 9));
        console.writeline(remove_char("atmiya university", 0));
    }
    public static string remove_char(string str, int n)
    {
        return str.remove(n, 1);
    }
}