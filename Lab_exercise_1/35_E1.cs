using system;

using system.linq;

class pro35
{
    static void main()
    {
        string str = "php tutorial";
        console.writeline((str.substring(1, 2).equals("hp") ? str.remove(1, 2) : str));
    }
}