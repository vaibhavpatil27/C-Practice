using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CsPractice
{
    class Program
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        static void Main(string[] args)
        {

            //-----------------------------------------------------------------------------------------------------
            //Hello World :-
            Console.Write("Hello World");
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Data Type: Integer
            Int32 num = 30;
            Console.Write(num);
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Data Type: Double
            double num1 = 30.33;
            Console.Write(num1);
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Data Type: Boolean
            Boolean status = true;
            Console.Write(status);
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Data Type: String
            String message = "Hello";
            Console.Write(message);
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Enumerations in C#:
            Console.Write(Days.Sun);
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //C# Variables:
            String message1 = "The value is ";
            Int32 val = 30;

            Console.Write(message1 + val);
            Console.ReadKey();



            //-----------------------------------------------------------------------------------------------------
            //Operators:
            Int32 val1 = 10, val2 = 20;
            bool status1 = true;

            Console.WriteLine(val1 + val2);
            Console.WriteLine(val1 < val2);
            Console.WriteLine(!(status1));
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //If Statements in C#:

            Int32 value = 11;

            if (value < 10)
            {
                Console.WriteLine("Value is less than 10");
            }
            else
            {
                Console.WriteLine("Value is greater than 10");
            }
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Switch Statements:

            Int32 value3 = 11;
            switch (value3)
            {
                case 1:
                    Console.WriteLine("Value is 1");
                    break;
                case 2:
                    Console.WriteLine("Value is 2");
                    break;
                default:
                    Console.WriteLine("value is different");
                    break;
            }


            //-----------------------------------------------------------------------------------------------------
            //While Loop in C#:

            Int32 value4 = 3, i = 0;

            while (i < value4)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
            Console.ReadKey();



            //-----------------------------------------------------------------------------------------------------
            //For Loop in C#:

            for (Int32 i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Arrays in C#:

            Int32[] Value5;
            Value5 = new Int32[3];

            Value5[0] = 1;
            Value5[1] = 2;
            Value5[2] = 3;

            Console.WriteLine(Value5[0]);
            Console.WriteLine(Value5[1]);
            Console.WriteLine(Value5[2]);

            Console.ReadKey();

            //-----------------------------------------------------------------------------------------------------
            //Class and Operators

            Tutorial pTutor = new Tutorial();

            pTutor.SetTutorial(1, ".Net");

            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();

            //-----------------------------------------------------------------------------------------------------
            //Access Specifiers and Inheritance in C#:
            VaibTutorial pTutor1 = new VaibTutorial();

            pTutor.RenameTutorial2(".Net by Vaib");

            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Abstarct Class

            VaibTutorial pTutor2 = new VaibTutorial();

            pTutor.SetTutorial(1, ".Net");

            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Interface

            VaibTutorial pTutor4 = new VaibTutorial();

            pTutor.SetTutorial(1, ".Net by Vaib");

            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();

            //-----------------------------------------------------------------------------------------------------
            //ArrayList in C#:

            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add("Example");
            a1.Add(true);

            Console.WriteLine(a1[0]);
            Console.WriteLine(a1[1]);
            Console.WriteLine(a1[2]);
            Console.ReadKey();

            //-----------------------------------------------------------------------------------------------------
            //Stack.Push:

            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the stack " + st.Count);
            Console.WriteLine("Does the stack contain the elements 3 " + st.Contains(3));
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Stack.Pop

            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            st.Pop();

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Queue in C#:

            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the Queue " + qt.Count);
            Console.WriteLine("Does the Queue contain " + qt.Contains(3));
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Dueue in C#:

            Queue qt1 = new Queue();
            qt1.Enqueue(1);
            qt1.Enqueue(2);
            qt1.Enqueue(3);

            qt1.Dequeue();

            foreach (Object obj in qt1)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();


            //-----------------------------------------------------------------------------------------------------
            //Hashtable in C#:

            Hashtable ht = new Hashtable();
            ht.Add("001", ".Net");
            ht.Add("002", "C#");
            ht.Add("003", "ASP.Net");

            ICollection keys = ht.Keys;

            foreach (String k in keys)
            {
                Console.WriteLine(ht[k]);
            }
            Console.ReadKey();




        }
    }
}


