using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace @struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();            
            sw.Start();
            var personClass = new PersonClass();
            personClass.test = new PersonClass1();
            personClass.test.Height1 = 100;
            var temp1 = personClass;
            for (var i = 0; i < 100000; i++) 
            {
                personClass.Height = 100;                
            }            
            sw.Stop();
            Console.WriteLine(temp1.Height);

            sw = new Stopwatch();            
            sw.Start();
            var personStruct = new PersonStruct();            
            personStruct.Height = 100;
            personStruct.test = new PersonStruct1();
            
            // これバグる
            //personStruct.test.Height1 = 0.00;
            //personClass.test.Height1 = personStruct.test.Height1; 

            var temp2 = personStruct;
            for (var i = 0; i < 100; i++)
            {
                personStruct.Height = 100;
            }
            sw.Stop();
            Console.WriteLine(temp2.Height);
            
            
        }
    }
    public class PersonClass
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public PersonClass1 test { get; set; }       
        public double GetBMI()
        {
            if (Height == 0 || Weight == 0)
                throw new InvalidOperationException();

            return Weight / (Height * Height);
        }
    }
    public struct PersonStruct
    {
        
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime Date { get; set; }
        public PersonStruct1 test { get; set; }       

        public double GetBMI()
        {
            if (Height == 0 || Weight == 0)
                throw new InvalidOperationException();

            return Weight / (Height * Height);
        }
    }
    public class test
    {
        public double Height1 { get; set; }
    }
    public class PersonClass1
    {
        public List<test> aaa { get; set; }
        public double Height1 { get; set; }
        public double Height2 { get; set; }
        public double Height3 { get; set; }
        public double Height4 { get; set; }
        public double Height5 { get; set; }
        public double Height6 { get; set; }
        public double Height7 { get; set; }
        public double Height8 { get; set; }
        public double Height9 { get; set; }
        public double Height10 { get; set; }
        public double Height11 { get; set; }
        public double Height12 { get; set; }
        public double Height13 { get; set; }
        public double Height14 { get; set; }
        public double Height15 { get; set; }

        public double Weight1 { get; set; }
        public double Weight2 { get; set; }
        public double Weight3 { get; set; }
        public double Weight4 { get; set; }
        public double Weight5 { get; set; }
        public double Weight6 { get; set; }
        public double Weight7 { get; set; }
        public double Weight8 { get; set; }
        public double Weight9 { get; set; }
        public double Weight10 { get; set; }
        public double Weight11 { get; set; }
        public double Weight12 { get; set; }
        public double Weight13 { get; set; }
        public double Weight14 { get; set; }
        public double Weight15 { get; set; }

    }
    public struct PersonStruct1
    {

        public double Height1 { get; set; }
        public double Height2 { get; set; }
        public double Height3 { get; set; }
        public double Height4 { get; set; }
        public double Height5 { get; set; }
        public double Height6 { get; set; }
        public double Height7 { get; set; }
        public double Height8 { get; set; }
        public double Height9 { get; set; }
        public double Height10 { get; set; }
        public double Height11 { get; set; }
        public double Height12 { get; set; }
        public double Height13 { get; set; }
        public double Height14 { get; set; }
        public double Height15 { get; set; }
         
        public double Weight1 { get; set; }
        public double Weight2 { get; set; }
        public double Weight3 { get; set; }
        public double Weight4 { get; set; }
        public double Weight5 { get; set; }
        public double Weight6 { get; set; }
        public double Weight7 { get; set; }
        public double Weight8 { get; set; }
        public double Weight9 { get; set; }
        public double Weight10 { get; set; }
        public double Weight11 { get; set; }
        public double Weight12 { get; set; }
        public double Weight13 { get; set; }
        public double Weight14 { get; set; }
        public double Weight15 { get; set; }
    }

}
