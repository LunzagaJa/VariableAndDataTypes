using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode1VariableAndDataType
{
    class Episode1Part2
    {

        static void Main(string[] args)
        {

            #region -- Local Variables --
            int sampleNumber = 3;
            var sampleNumberImplicit = 3;
            dynamic sampleNumberDynamic = 5;
            Console.WriteLine("This is my sample: "+sampleNumber);
            #endregion
            #region --Class Variables--
            // Instance variables
            var episode1 = new Episode1Class();
            Console.WriteLine(episode1.samplePublicInt);
            episode1.samplePublicInt = 250;
            Console.WriteLine(episode1.samplePublicInt);

            //Class  or Static Variables

            Console.WriteLine("*************");
            Console.WriteLine(Episode1Class.sampleStaticOrClassVariableInt);
            Episode1Class.sampleStaticOrClassVariableInt = 500;
            Console.WriteLine(Episode1Class.sampleStaticOrClassVariableInt);


            #endregion
            // delete this entire function
            // Parse and convert
            #region -- parse and convert --
            String textOne = "3";
            var intOne = int.Parse(textOne);
            var result = intOne * 5;
            Console.WriteLine($" Parse  = Text one result: {result}");

            var intConverted = Convert.ToInt32(textOne);
            result = intConverted * 6;
            Console.WriteLine($" Convert = Text one result: {result}");
            #endregion
        }
    }
    public class Episode1Class
    {
        public static int sampleStaticOrClassVariableInt = 3;

        public int samplePublicInt = 500;
        private int samperPrivateInt = 100;

        #region -- Fields --
        int sampleFieldInt = 5;
        static int sampleStaticInt = 6;
        readonly long sampleLong;
        readonly long sampleLong2 = 10;
        const int sampleIntnNaConst = 150;
        const float mathPi = 3.14f;
        #endregion

        public Episode1Class()
        {
            sampleLong = 500;
            sampleLong2 = 100;

        }
        public void SampleMethod1()
        {
            int sampleLocalInt = 1;
            var sampleLocalDouble = 2;
            sampleFieldInt = 1;
            sampleStaticInt = 2;

        }
        public void sampleMethod2()
        {
            int sample2Int = 1;

        }
        public static void sampleMethod1()
        {
            sampleStaticInt = 0;

        }
    }
}