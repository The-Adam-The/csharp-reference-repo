
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Types

            //value types

            byte number = 3;
            int count = 10;
            float totalPrice = 20.98f;
            char character = 'a';
            bool isWorking = true;

            Console.WriteLine("value types:");
            Console.WriteLine("number: " + number);
            Console.WriteLine("count: " + count);
            Console.WriteLine("totalPrice: " + totalPrice);
            Console.WriteLine("character: " + character);
            Console.WriteLine("isWorking: " + isWorking);

            //reference types
            Console.WriteLine("Reference variables:");
            string firstName = "Mosh";
            Console.WriteLine("firstName: " + firstName);

            // var examples
            var varNumber = 3;
            var varCount = 10;
            var varTotalPrice = 20.98f;
            var varCharacter = 'a';
            var varFirstName = "Mosh";
            var varIsWorking = true;

            Console.WriteLine("\n");
            Console.WriteLine("var variables:");
            Console.WriteLine("\n");

            Console.WriteLine("varNumber: " + varNumber);
            Console.WriteLine("varCount: " + varCount);
            Console.WriteLine("varTotalPrice: " + varTotalPrice);
            Console.WriteLine("varCharacter: " + varCharacter);
            Console.WriteLine("varFirstName: " + varFirstName);
            Console.WriteLine("varIsWorking: " + varIsWorking);

            Console.WriteLine("\n");

            //String interpolation
            Console.WriteLine("String Interpolation");
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //Constant variable
            const float Pi = 3.14f;
            Console.WriteLine("\n");

            //Type conversion

                //implicit
                Console.WriteLine("Implicit type conversion:");
                byte b = 1;
                Type btype = b.GetType(); 
                Console.WriteLine("b type: " + btype);
            
                int i = b;
                Type itype = i.GetType();
                Console.WriteLine("i type: " + itype);
                Console.WriteLine("\n");

                //explicit
                Console.WriteLine("Explicit type conversion:");

                int IExplicit = 1;
                Type IExplicitType = IExplicit.GetType();
                Console.WriteLine("IExplicitType: " + IExplicitType);
 
            
                byte bExplicit = (byte)i;
                Type bExplicitType = bExplicit.GetType();
                Console.WriteLine("BExplicitType: " + bExplicitType);

                Console.WriteLine("\n");

                //Converting non-compatible types

                //string to number

                string numberString = "30";
                Console.WriteLine("numberString: " + numberString);
                Type numberStringType = numberString.GetType();
                Console.WriteLine("numberStringType: " + numberStringType);


                //Using 'Convert.ToInt32()' method
                int convertNumber = Convert.ToInt32(numberString);
                Type convertNumberType = convertNumber.GetType();

                Console.WriteLine("convertNumberType: " + convertNumberType);

                //Using Parse Method
                int parseNumber = int.Parse(numberString);
                Type parseNumberType = parseNumber.GetType();
      
                Console.WriteLine("parseNumberType: " + parseNumberType);

            //Operators

                //incrementer

                //prefix incrementer
                int preOne = 1;
                int outputPre = ++preOne;
                Console.WriteLine("Prefix incrementer:");
                Console.WriteLine("preOne: " + preOne);
                Console.WriteLine("outputPre: " + outputPre);

                //postfix incrementer
                int onePost = 1;
                int outputPost = onePost++;
                Console.WriteLine("Postfix incrementer:");
                Console.WriteLine("onePost: " + onePost);
                Console.WriteLine("outputPost: " + outputPost);

            //Logical Operators

                int logicOne = 1;
                int logicTwo = 2;
                int logicThree = 3;
            Console.WriteLine("\n");
            Console.WriteLine("Logical Operators:");
            Console.WriteLine ("logicOne == logicOne:" + (logicOne == logicOne));
            Console.WriteLine ("logicOne != logicOne:" + (logicOne != logicOne));
            Console.WriteLine ("logicOne != logicOne:" + (logicOne != logicOne));
            Console.WriteLine("logicOne < logicthree && logicTwo < logicThree: " + (logicOne < logicThree && logicTwo < logicThree));
            Console.WriteLine("logicOne > logicthree && logicTwo < logicThree: " + (logicOne > logicThree && logicTwo < logicThree));
            Console.WriteLine("true || false: " + (true || false));
            Console.WriteLine("false || false: " + (false || false));



        }

    }
}