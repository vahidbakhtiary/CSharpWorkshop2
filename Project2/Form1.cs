using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //Cast

            //Implicit (Auto Cast)
            //int varInt = 10;
            //long varLong = varInt;


            //Explicit
            long varLong = 10;
            int varInt = (int) varLong;


            //Common String Operations

            //Replcae
            string str = "this is a test for test";
            string newStr = str.Replace("test", "Sample");

            Console.WriteLine(str);
            Console.WriteLine(newStr);

            //Change Case
            string s = "Ali REza";
            //string newS = s.ToLower();
           string newS = s.ToUpper();

            Console.WriteLine(s);
            Console.WriteLine(newS);

            //sample   (comment ===> ctrl + K + C ,   uncomment ===> ctrl + K + U)
            //if (s.ToUpper().Equals("ali reza".ToUpper()))
            //{
            //    Console.WriteLine("true");
            //}else
            //{
            //    Console.WriteLine("false");
            //}


            //Check Empty or Null or WhiteSpcase
            string text1 = "";         //Empty
            string text2 = " ";        // fill (space)
            string text3 = "    ";     // fill (spaces)
            string text4 = "ali";      // fill
            string text5 = null;       // null  

            //Console.WriteLine(String.IsNullOrEmpty(text1)); 
            //Console.WriteLine(String.IsNullOrEmpty(text2)); 
            //Console.WriteLine(String.IsNullOrEmpty(text3)); 
            //Console.WriteLine(String.IsNullOrEmpty(text4)); 
            //Console.WriteLine(String.IsNullOrEmpty(text5)); 


            //Console.WriteLine(String.IsNullOrWhiteSpace(text1));
            //Console.WriteLine(String.IsNullOrWhiteSpace(text2));
            //Console.WriteLine(String.IsNullOrWhiteSpace(text3));
            //Console.WriteLine(String.IsNullOrWhiteSpace(text4));
            //Console.WriteLine(String.IsNullOrWhiteSpace(text5));


            //Substrings
            string text = "my name is vahid";
            int length = text.Length;
            Console.WriteLine(length);

           string newText = text.Substring(3, 7);

            Console.WriteLine(text);
            Console.WriteLine(newText);


            //Trim 
            string name = "  ali             ";
            if (name.Trim() .Equals("ali"))
            {
                Console.WriteLine("true");
            }else
            {
                Console.WriteLine("false");
            }

        }
    }
}
