class pro28
{
     static void main()
    {

        string hexval = "4b0";
        console.writeline("hexadecimal number: " + hexval);
        int decvalue = int.parse(hexval, system.globalization.numberstyles.hexnumber);
        console.writeline("convert to-");
        console.writeline("decimal number: " + decvalue);
    }
}