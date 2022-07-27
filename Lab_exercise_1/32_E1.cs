using system;
using system.linq;


 class pro32
    static void main()
    {
        string str;
        console.write("input a string : ");
        str = console.readline();
        console.writeline((str.length < 6 && str.equals("hello")) || (str.startswith("hello") && str[5] == ' '));
    }
}