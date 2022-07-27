using system;
using system.linq;

 class pro30
 {
  static void main()
        {
           string str; 
           int l= 0;
           console.write("input a string : ");
           str = console.readline();
           if (str.length>4)
           {
              console.writeline(str.length < 4 ? str + str + str : str.substring(str.length - 4)+ str.substring(str.length - 4) + str.substring(str.length - 4) + str.substring(str.length - 4));
           }
        }
}