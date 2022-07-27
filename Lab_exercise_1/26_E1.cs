
using system;
using system.linq;

class pro26
{
    static void main()
    {
        string text = "my girlfriend name is natasha patel";

        console.writeline(string.join(" ", text.split(' ').reverse()));
    }
}