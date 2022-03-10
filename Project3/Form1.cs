using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
               if (condination)
               {
               }

            if (condination)
               {

               }else
               {

               }

            if (condination)
               {
               }else if (condination)
               {
               }else
               {
               }
               
             */

            //Example 1

            //int number = 6;
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("event");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}


            //Example 2
            int number = 3;
            //if (number == 1)
            //{
            //    Console.WriteLine("one");
            //}
            //else if (number == 2)
            //{
            //    Console.WriteLine("Two");
            //}
            //else if (number == 3)
            //{
            //    Console.WriteLine("Three");
            //}
            //else
            //{
            //    Console.WriteLine("not found");
            //}

            //switch(number)
            //{
            //    case 1:
            //        Console.WriteLine("one");
            //        break;

            //    case 2:
            //        Console.WriteLine("Two");
            //        break;

            //    case 3:
            //        Console.WriteLine("Three");
            //        break;

            //    default:
            //        Console.WriteLine("not found");
            //        break;
            //}


            //Loop
            for (int i=0; i<=10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
