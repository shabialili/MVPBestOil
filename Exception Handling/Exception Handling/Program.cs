using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exception_Handling
{
    class Program
    {
        static int Calc(int x) => 10 / x;
        static void Main(string[] args)
        {
            try
            {
                int result = Calc(0);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                //Console.WriteLine(ex.Message);
            }
        }



        //static void Main(string[] args)
        //{
        //    string[] data = new string[3] { "salam", "512", "hello" };
        //    try
        //    {
        //        byte a = byte.Parse(data[1]);
        //    }
        //    catch (IndexOutOfRangeException)
        //    {
        //        Console.WriteLine("Index out of range exception");
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("That is not a number");
        //    }
        //    catch (OverflowException)
        //    {
        //        Console.WriteLine("You have given me more than a byte");
        //    }
        //}
        //

        //static void Main(string[] args)
        //{
        //    string[] data = new string[3] { "salam", "512", "hello" };
        //    try
        //    {
        //        byte a = byte.Parse(data[500]);
        //    }
        //    catch 
        //    {
        //        Console.WriteLine("Error");
        //    }
        //    Console.WriteLine("Continue");
        //}



        //static void Display(string data)
        //{
        //    if (data == null)
        //    {
        //        throw new ArgumentNullException(nameof(data));
        //    }
        //    Console.WriteLine(data);
        //}
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Display(null);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}




        //static void Display(string data)
        //{
        //    if (data == null)
        //    {
        //        throw new ArgumentNullException(nameof(data));
        //    }
        //    Console.WriteLine(data);
        //}
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Display(null);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Program works");
        //        //programda error cixsada cixmasada finally bloku isleyir
        //    }
        //}

        //static int GetInt(int[]array,int index)
        //{
        //    try
        //    {
        //        return array[index];
        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {

        //        throw new ArgumentOutOfRangeException (
        //            "Parametr index is out of range" , ex);
        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {

        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int[] array = { 1, 2, 3, 4, 5 };
        //    GetInt(array, 100);
        //}
    } 
}

