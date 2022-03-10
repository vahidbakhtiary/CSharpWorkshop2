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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();




            //Array

            int a = 10;
            int b = 20;
            int c = 30;

            //Define 1 
            //int[] array = new int[3];
            //array[0] = 10;
            //array[1] = 20;
            //array[2] = 30;

            //Define 2
            //int[] array = new int[3] { 10 , 20 , 30};
            //int[] array2 = new int[] { 10, 20, 30 };
            //string[] array3 = new string[] { "diplom", "BA", "MS", "PHD" };


            //Define 3
            var array = new int[3] { 10, 20, 30 };
            var array2 = new int[] { 10, 20, 30 };
            var array3 = new [] { 10, 20, 30 };



            //Console.WriteLine(array[0]);
            //Console.WriteLine(array[1]);
            //Console.WriteLine(array[2]);


            Console.WriteLine(array.Length);
            //Scanig
            for( int i=0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("-------------------");
            for( int i = array.Length - 1 ; i>=0; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("-------------------");

            foreach(var item in  array)
            {
                Console.WriteLine(item);
            }




            //Example 2
            string[] names = new[] { "ali", "reza", "mina" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            Console.WriteLine("--------------------");

            for(int i=0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("--------------------");

            foreach (var item in  names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
