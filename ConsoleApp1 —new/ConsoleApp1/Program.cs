#define DEBUG
#define VC_V10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using HAOK_1;
using HAOK_2;
using ClassLibrary1;
using first1_space;
using second1_space;


namespace consoleapp1 {//name of project
    interface ISomeInterface //no access modificator needed
    {
    int property { get; set; }
    void Print(); //method needed to be realized in inherided
    }
    interface IDraw //no access modificator needed
    {
        void Draw(); //method needed to be realized in inherided
    }
    class Test : ISomeInterface, IDraw
    {
        public int property { get; set; }
        public void Print()
        {
            Console.WriteLine("Text_1 from Interface");
        }
        public void Draw()
        {
            Console.WriteLine("From second interface - Draw method");
        }
    }

    class Test2 : ISomeInterface
    {
        public int property { get; set; }
        public void Print()
        {
            Console.WriteLine("Text_2 from Interface");
        }
    }

    class SomeReloadMeth //Reload of Methods
    {
        public void Multiply (int a, int b)
        {
            Console.WriteLine("Result is:" + a * b);
        }
        public void Multiply3(int a, int b, int c)
        {
            Console.WriteLine("Result of another method is:" + a * b * c);
        }
        public void Multiply(int a, int b, int c)
        {
            Console.WriteLine("Result of reload is:" + a * b * c);
        }
        public void Multiply(int a, int b, int c, int d)
        {
            Console.WriteLine("Result of reload is:" + a * b * c * d);
        }
        public void Multiply(string a)
        {
            Console.WriteLine("Result of reload is:" + a);
        }
    }
    struct Book //STRUCTURE - outside from class
    {
        public string title;
        public string name;
        public string author;
        //public string name = "Sam";     // ! Ошибка
        //Constructor is Method with the name of Structure
        public Book(string title, string name, string author)
        {
            this.title = title; this.name = name; this.author = author;
        }
        public void Print()
        {
            Console.WriteLine("Structure Title - " + title);
            Console.WriteLine("Structure Name - " + name);
            Console.WriteLine("Structure Author - " + author);
        }
    }
    struct User
    {
        public int age;
        public string name;
    }
    class User1
    {
        public int age;
        public string name;
    }
    class Person
    {
        public int age;
        string name;
        public void Display()
        {
            Console.WriteLine($"Name: {name}");
        }
        public int age1;
        //Конструктор вызывает конструктор
        public Person() : this("Неизвестно")
        {
        }
        public Person(string name) : this(name, 18)
        {
        }
        public Person(string name, int age1)
        {
            this.name = name;
            this.age = age;
        }
    }
    enum Days
    {
        Monday = 10,//0
        Tuesday,//1
        Wednesday//2
    }
    enum Color
    {
        White = 1,
        Black = 2,
        Green = 2,
        Blue = White // Blue = 1
    }
    enum Oper { Add, Subtract, Divide, Multiply}
    class program
    {
        public static void Main(string[] args) //Метод Main потому, что ничего не возвращает 
        { //static Main method can only call static methods
            Console.WriteLine("\t\t\t\t\t\tBASIC C#\n\n\n");
            int x_choose;
            Content:
            Console.WriteLine("\t\t\t\t\tCONTENT\n");
            Console.WriteLine("1\t\t\tVariable types & Basic operations");
            Console.WriteLine("2\t\t\tConditions (IF/ELSE, SWITCH/CASE)");
            Console.WriteLine("3\t\t\tLOOPS (FOR/WHILE/DO WHILE)");
            Console.WriteLine("4\t\t\tMassives");
            Console.WriteLine("5\t\t\tMulti-dimensional arrays");
            Console.WriteLine("6\t\t\tLists");
            Console.WriteLine("7\t\t\tStrings");
            Console.WriteLine("8\t\t\tTry & Catch");
            Console.WriteLine("9\t\t\tClasses & Objects, Properties, GET/SETS");
            Console.WriteLine("10\t\t\tMethods, Functions, ref, out, param, recursion");
            Console.WriteLine("11\t\t\tINHERITANCE, AS/IS, Virtual methods, Abstract classes (From External Class file)");
            Console.WriteLine("12\t\t\tInterfaces (multi-inheritance)");
            Console.WriteLine("13\t\t\tReload of Method, Reload of Operators, Преобразование типов/classes");
            Console.WriteLine("14\t\t\tENUM");
            Console.WriteLine("15\t\t\tSTRUCTURES, Massive of structures");
            Console.WriteLine("16\t\t\tTuples");
            Console.WriteLine("17\t\t\tREFERENCES Variables & Methods");
            Console.WriteLine("18\t\t\tShadowing / hiding of methods, properties, variables");
            Console.WriteLine("19\t\t\tRegular Expressions, File I/O");
            Console.WriteLine("20\t\t\tPreprocessor Directives");
            Console.WriteLine("21\t\t\tNamespaces");
            Console.WriteLine("22\t\t\tNullables");
            x_choose =Convert.ToInt32(Console.ReadLine());
            switch (x_choose)
            {
                case 1: //Variable types & Basic operations
                    {
                        Console.WriteLine("1\t\t\tVariable types & Basic operations");
                        Console.Write("First line \t text after tab \t text after tab \nSecond line\n");
                        //var num; not right
                        //num = 10;
                        var num = 10; //we cannot change type of variable by changing value
                        int o = 9;
                        o = o + 1;
                        o += 3;
                        o++; //add 1, -- -1
                        uint n = 10;//>0
                        uint a3 = 10U;
                        long b3 = 20L;
                        ulong c3 = 30UL;
                        byte xx = 3;
                        double yy = 45.4; //by default if no "f"
                        decimal rate = 5.6M;
                        System.Int32 b4 = 4;
                        const float u = 1.22f;
                        object obj1 = 1;
                        object obj2 = "Object";
                        char e = 'r';
                        string w = "Hello";
                        ushort n1 = 1;//хранит целое число от 0 до 65535 и занимает 2 байта
                        var c5 = 20;
                        Console.WriteLine("Type = " + c5.GetType());
                        Console.WriteLine(c5.GetType().ToString());
                        bool t = true;
                        char c = 'c'; //Initialization - is given value while declaring
                        byte a11 = 4;
                        byte b11 = (byte)(a11 + 70);//сужающее преобразование (явно)
                        int b12 = a11 + 70;//1 byte -> 4 byte расширенное преобразование типов (неявно)
                        short c11 = (short)(a11 + 80);
                        //byte (1 byte) -> short (2 byte) -> int (4 byte) -> long (8 byte) -> decimal (16 byte)
                        //byte (1 byte) -> short (2 byte) -> int (4 byte) -> double (8 byte) 
                        //byte (1 byte) -> short (2 byte) -> float (4 byte) -> double (8 byte) 
                        //char (2 byte) -> int (4 byte)
                        //double -> X decimal
                        Console.WriteLine(3.2e3);   // по сути равно 3.2 * 10<sup>3</sup> = 3200
                        Console.WriteLine(1.2E-1);  // равно 1.2 * 10<sup>-1</sup> = 0.12
                        Console.WriteLine('\x5A');    // Z
                        Console.WriteLine('\u0420');    // Р
                        Console.WriteLine("Компания \"Рога и копыта\"");
                        double d11 = 33.0;
                        decimal d22 = (decimal)d11;
                        try
                        {
                            int a12 = 33;
                            int c12 = 600;
                            byte b112 = checked((byte)(a11 + c));
                            //byte b112 = (byte)(a11 + c);
                            Console.WriteLine($"Byte shortened - {b112}");
                        }
                        catch (OverflowException){
                            Console.WriteLine("Not valid segment");
                        }
                        //==, !=, &&, || - second operand we may not calculate
                        bool t1 = (5 > 6) | (4 < 6); // -; + True - if 1 is true -> true
                        bool t12 = (5 > 6) | (4 > 6); // -; - False
                        bool t13 = (5 < 6) & (7 > 6); // +; + True - if 2 true -> true
                        Console.WriteLine($"T1 = {t1}, T12 = {t12}, T13 = {t13}");
                        //a ^ b -> if a = b -> true; false = false; true = true
                        //10 % 6 = 4;
                        string name1 = "Tom";
                        int age1 = 34;
                        double height1 = 1.7;
                        Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name1, height1, age1);
                        Console.WriteLine($"Имя: {name1}  Возраст: {age1}  Рост: {height1}м");
                        Console.WriteLine("\t\t\t\t\t\tBASIC OPERATIONS\n\n\n");
                        double r= 10.0 / 4;//2.5
                        int a = 4; //Postfix/Prefix increment/decrement
                        //int b = a++; //a=5, b=4
                        int b = ++a; //a=5, b=5
                        Console.WriteLine($"a ={a} b = {b}");
                        int aa = 4;
                        //int bb = --aa;//aa=3. bb=3
                        int bb = aa--;//aa=3. bb=4
                        Console.WriteLine($"aa ={aa} bb = {bb}");
                        Console.WriteLine(r);
                        //1 Increment/ decrement, 2 */
                        int a1 = 3, b1=5, c1=40;
                        int d2 = 0;
                        //int d1 = c1-- - b1 * a1; // = 2.5 ?
                        //int d2 = (c1-(--b1)) * a1; //d2=108
                        //(c--)=40  c=39
                        //b*a=15
                        //40-15 =25
                        Console.WriteLine($"a1 ={a1} b1 = {b1} c1 = {c1} d2={d2}");
                        int x, y;
                        Console.WriteLine("Enter first number");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Result of ADDIDNG is " + (x + y).ToString());
                        Console.WriteLine("Result of MULTIPLICATION is " + (x * y).ToString());
                        Console.WriteLine("Result of SUBTRACTION is " + (x - y).ToString());
                        Console.WriteLine("\t\t\tLogical operations: & | ^ ~ <<, >>");
                        int x1 = 2; //010
                        int x2 = 5; //101
                                    //000 - &
                                    //111 - 7 - |
                        Console.WriteLine($"Logical multiplication (&) of {x1} and {x2} =" + (x1&x2));
                        Console.WriteLine($"Logical sum (|) of {x1} and {x2} =" + (x1 | x2));
                        int y1 = 4; //100
                             //int y3 = 0b100; = 4
                        int y2 = 0b101; //101 = 5
                                        //100 - 4 - &
                                        //101 = 5 - |
                                        //001 = XOR ^
                        int encrypt = y1 ^ y2;
                        int y3 = 9; //1001 -> 0110
                        Console.WriteLine($"Logical multiplication (&) of {y1} and {y2} =" + (y1 & y2));
                        Console.WriteLine($"Logical sum (|) of {y1} and {y2} =" + (y1 | y2));
                        Console.WriteLine($"Logical XOR ENCRYPT (^) of {y1} and {y2} =" + (encrypt));
                        int decrypt = encrypt ^ y2;
                        Console.WriteLine($"Logical XOR DECRYPT (^) of {y1} =" + (decrypt));
                        Console.WriteLine($"Logical Deny (~) of {y3} =" + (~ y3));
                        Console.WriteLine($"Result of ~{y3} =" + Convert.ToString((~y3),2));
                        int x3 = 4; //100
                        Console.WriteLine(x3 << 1); //1000 - 8
                        Console.WriteLine(x3 << 2); //10000 - 16
                        Console.WriteLine(x3 >> 1); //10 - 2
                        Console.WriteLine(x3 >> 2); //1 - 1
                        string name = "Tom";
                        int age = 34;
                        double height = 1.7;
                        Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);
                        Console.WriteLine(DateTime.Now);
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 2: //Conditions (IF/ELSE, SWITCH/CASE)
                    {
                        double j;
                        Console.WriteLine("\t\t\t\t\t\tIF/ELSE IF/ELSE");
                        Console.WriteLine("How old are you?");
                        j = Convert.ToDouble(Console.ReadLine());
                        if (j > 18 && j < 50)
                            Console.WriteLine("You are older than 18 AND smaller than 50\n");
                        else if (j == 18 || j == 50)
                            Console.WriteLine("You are 18 OR 50\n");
                        else
                            Console.WriteLine("You are older than 50 OR smaller than 18\n");
                        Console.WriteLine("\t\t\t\t\t\tSHORT IF/ELSE IF/ELSE");
                        string name = j >= 25 ? "You are 25 OR older than 25" : "You are younger than 25";
                        int x = 3;
                        int y = 2;
                        Console.WriteLine("Write + or - ");
                        string sel = Convert.ToString(Console.ReadLine());
                        int res = (sel=="+") ? (x + y) : (x - y);
                        Console.WriteLine("Result of ternarn operator = " + res);
                        Console.WriteLine("\t\t\t\t\tSWITCH/CASE & RANDOM NUMBER");
                        Console.WriteLine("C# generates random number (F) from 1 to 3");
                        Random randNum = new Random();
                        int f = randNum.Next(1, 4);
                        Console.WriteLine("Random number (F) = " + f);
                        switch (f)
                        {
                            case 1:
                                Console.WriteLine("F is equal " + f);
                                break;
                            case 2:
                                Console.WriteLine("F is equal " + f);
                                break;
                            case 3:
                                Console.WriteLine("F is equal " + f);
                                break;
                            default:
                                Console.WriteLine("Other");
                                break;
                        }
                        Console.WriteLine("Write char YY or TT or NN");
                        string k = Convert.ToString(Console.ReadLine());
                        switch (k)
                        {
                            case "YY":
                                Console.WriteLine("Case = YY");
                                // return; - exit at all
                                goto case "NN";
                                break;
                            case "TT":
                                Console.WriteLine("Case = TT");
                                break;
                            case "NN":
                                Console.WriteLine("Case = NN");
                                break;
                        }
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 3: //Loops (FOR/WHILE/DO WHILE)
                    { 
                        Console.WriteLine("\t\t\t\t\tFOR");
                        //for ( ; ;) = endless
                        for (int i = 0; i <= 5; i++)
                        {
                            Console.Write(i + "\t");
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("Another FOR with IF:");
                        for (int ii = 10; ii >= 5; ii -= 1)
                        {
                            if (ii == 8)
                                continue;//пропуск 8, но не выход с функции
                            //break - exit loop
                            Console.Write(ii + "\t");
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("\t\t\t\t\tWHILE");
                        int iii = 0;
                        while (iii <= 6)
                        {
                            Console.Write(iii + "\t");
                            iii++;
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("\t\t\t\t\t DO WHILE");
                        Console.WriteLine("You should enter number until you enter 5");
                        int numb;
                        do
                        {
                            Console.WriteLine("Enter number = ");
                            numb = Convert.ToInt32(Console.ReadLine());
                        } while (numb != 5);
                        Console.WriteLine("\n");

                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 4: //Massives
                    {
                        Console.WriteLine("\t\t\t\t\t MASSIVES");
                        int[] nums3 = new int[] { 1, 2, 3, 5 };
                        //int[] nums3 = new int[4] { 1, 2, 3, 5 };
                        int[] nums4 = new[] { 1, 2, 3, 5 };
                        int[] nums5 = { 1, 2, 3, 5 };
                        int[] ar = new int[5];//массив
                        ar[0] = 20;
                        ar[1] = 21;
                        ar[2] = 22;
                        ar[3] = 23;
                        ar[4] = 24;
                        int[] ar1 = { 1, 2, 3 };
                        int[] ar12 = new int [3]{ 1, 2, 3 };
                        Console.WriteLine("Third element = " + ar[3]);
                        for (int i = 0; i < ar.Length; i++)
                            Console.Write(ar[i] + ", ");
                        Console.WriteLine("\n");
                        string[] st = new string[3] { "Anna", "Helen", "Luda" };
                        for (int i = 0; i < st.Length; i++)
                            Console.Write(st[i] + ", ");
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 5: //Multi-dimensional arrays
                    {
                        Console.WriteLine("\t\t\tMulti-dimensional arrays");
                        Console.WriteLine("Многомерный массив");
                        Console.WriteLine("Каждый элемент есть массивом");
                        int[,] nu = new int[10, 10];
                        //nu[0, 0] = 11;
                        //nu[0, 1] = 12;
                        //nu[0, 2] = 13;
                        //nu[1, 0] = 21;
                        //nu[1, 1] = 22;
                        //nu[1, 2] = 23;
                        //nu[2, 0] = 31;
                        //nu[2, 1] = 32;
                        //nu[2, 2] = 33;
                        Console.WriteLine(nu[1, 2]);
                        for (int i = 0; i < 10; i++)
                        {
                            for (int jj = 0; jj < 10; jj++)
                            {
                                nu[i, jj] = i + jj;
                                Console.Write(nu[i, jj] + " ");
                            }
                            Console.WriteLine();
                        }
                        float[] cc = { 1.23f, 2.23f, 3.43f, 8.34f };
                        foreach (float el in cc) //without length
                        {
                            Console.WriteLine(el);
                        }
                        int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };
                        int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
                        int[,] nums11;
                        int[,] nums21 = new int[2, 3];
                        int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
                        int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
                        int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
                        int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };
                        int[,,] nums31 = new int[2, 3, 4];
                        int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
                        foreach (int i in mas)
                            Console.Write($"{i} ");
                        Console.WriteLine();
                        int[,] mas1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
                        int rows = mas1.GetUpperBound(0) + 1;
                        Console.WriteLine("Rows = " + rows);
                        //int columns = mas1.Length / rows;
                        int columns = mas.GetUpperBound(1) + 1;
                        Console.WriteLine("Columns = " + columns);
                        // или так
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                Console.Write($"{mas1[i, j]} \t");
                            }
                            Console.WriteLine();
                        }
                        int[][,] nums10 = new int[3][,]
                        {
                            new int[,] { {1,2}, {3,4} },
                            new int[,] { {1,2}, {3,6} },
                            new int[,] { {1,2}, {3,5}, {8, 13} }
                        };
                        //зубчатые массивы
                        int[][] numbers = new int[3][];
                        numbers[0] = new int[] { 1, 2 };
                        numbers[1] = new int[] { 1, 2, 3 };
                        numbers[2] = new int[] { 1, 2, 3, 4, 5 };
                        foreach (int[] row in numbers)
                        {
                            foreach (int number in row)
                            {
                                Console.Write($"{number} \t");
                            }
                            Console.WriteLine();
                        }
                        // перебор с помощью цикла for
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            for (int j = 0; j < numbers[i].Length; j++)
                            {
                                Console.Write($"{numbers[i][j]} \t");
                            }
                            Console.WriteLine();
                        }
                        //Найдем количество положительных чисел в массиве
                        int[] numbers11 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
                        int result = 0;
                        foreach (int number in numbers11)
                        {
                            if (number > 0)
                            {
                                result++;
                            }
                        }
                        Console.WriteLine($"Число элементов больше нуля: {result}");
                        int [] numbers1 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
                        // инверсия массива, то есть переворот его в обратном порядке
                       int n = numbers1.Length; // длина массива
                        int k = n / 2;          // середина массива
                        int temp;               // вспомогательный элемент для обмена значениями
                        for (int i = 0; i < k; i++)
                        {
                            temp = numbers1[i];
                            numbers1[i] = numbers1[n - i - 1];
                            numbers1[n - i - 1] = temp;
                        }
                        foreach (int  i in numbers1)
                        {
                            Console.Write($"{i} \t");
                        }
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 6: //Lists - we don't know number of elements, uses more memory
                    {
                        Console.WriteLine("\t\t\t\t\t LISTS");//using System.Collections.Generic;
                        List<int> numbers = new List<int>();
                        numbers.Add(11);
                        numbers.Add(12);
                        numbers.Add(13);
                        numbers.Add(14);
                        Console.WriteLine(numbers[1]);
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write(numbers[i] + ", ");
                        Console.WriteLine("\n");
                        Console.WriteLine("Remove element with index[0]");
                        numbers.RemoveAt(0);
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write(numbers[i] + ", ");
                        Console.WriteLine("Remove element 13");
                        numbers.Remove(13);
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write(numbers[i] + ", ");
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 7: //Strings
                    {
                        Console.WriteLine("\t\t\tStrings");
                        string a = "Hello";
                        Console.WriteLine(a[1]);
                        string str = "   ";
                        Console.WriteLine(str[2] + "Length: " + str.Length);
                        Console.WriteLine(String.IsNullOrEmpty(str));//if Spaces = False
                        Console.WriteLine(String.IsNullOrWhiteSpace(str));//if Spaces or \t = True
                        Console.WriteLine(String.Compare("a", "b")); //b>a -> -1;  a=a ->0, a>b ->1, a<b ->1
                        string str1 = "HELLO MY WORLD, ARCENAL, Dynamo";
                        Console.WriteLine(str1.ToLower());
                        Console.WriteLine(str1.ToUpper());
                        Console.WriteLine(str1.ToLower());
                        Console.WriteLine(str1.Contains("LLO"));
                        Console.WriteLine(str1.StartsWith("HEL"));
                        Console.WriteLine(str1.EndsWith("RLD"));
                        Console.WriteLine(str1.EndsWith("nal"));
                        Console.WriteLine(str1.Insert(2, "D")); //insert after
                        Console.WriteLine(str1.Remove(3)); //Remove after
                        Console.WriteLine(str1.Replace("HE", "CA"));
                        char[] sym = str1.ToCharArray(); //convert string to array
                        string[] clubs = str1.Split(',');
                        Console.WriteLine(clubs[2]);
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 8: //Try & Catch
                    {
                        Console.WriteLine("\t\t\tTry & Catch");
                        Console.WriteLine("Enter number: ");
                        try
                        {
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Num is - " + num1);
                            //return false; finally - will work
                        }
                        catch (FormatException)
                        { //DivideByZeroException, Exception(for all), IndexOutOfRangeException
                            Console.WriteLine("Format Exception");
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine($"IndexOutOfRangeException {ex.Message}");
                        }
                        finally //works 100% - not mandatory
                        {
                            Console.WriteLine("End");
                        }
                        int[] nums = new int[4];
                        try
                        {
                            nums[5] = 23;
                            Console.WriteLine("Try block END");
                        }
                        /* catch
                         {
                             Console.WriteLine("Error occured");
                         }*/
                        catch(Exception ex) //for general
                        {
                            Console.WriteLine($"Error occured {ex.Message}");
                            Console.WriteLine("Error occured");
                        }
                        try
                        {
                            Console.WriteLine("Write string:");
                            string s = Console.ReadLine();
                            if (s.Length > 4)
                            {
                                throw new Exception("Length is more than 4");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error occured {ex.Message}");
                        }
                        int x8 = 0;
                        int y8 = 0;
                        try
                        {
                            int result = x8 / y8;
                        }
                        catch (DivideByZeroException) when (y8 == 0 && x8 == 0)
                        {
                            Console.WriteLine("y не должен быть равен 0");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        try
                        {
                            int x = 5;
                            int y = x / 0;
                            Console.WriteLine($"Результат: {y}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Исключение: {ex.Message}");
                            Console.WriteLine($"Метод: {ex.TargetSite}");
                            Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
                        }
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 9: //Object & Classes, Properties, GET/SETS (for private)
                    {
                        Console.WriteLine("\t\t\tClasses & Objects, Properties, GET/SETS");
                        Animal cat = new Animal(); //object from class Animal
                                                   //Console.WriteLine(cat.name);
                                                   //cat.name = "NEW NAME OF CAT";
                                                   //Console.WriteLine(cat.name);
                                                   //Console.WriteLine(cat.age);
                                                   //cat.Print();
                                                   //Animal.count++;
                                                   //cat.count++; if no static
                        Console.WriteLine();
                        Animal dog = new Animal(); //object from class Animal
                                                   //Animal.count++; if we have static int count
                                                   //Console.WriteLine(dog.count);
                                                   //Console.WriteLine(Animal.count); //2 - because variable is static
                        dog.Surname = "Ostapenko"; //from GET. Property - name as variable but capitalized
                        string surn = dog.Surname; //via SET
                        Console.WriteLine("Surname from GET/SET = " + dog.Surname);
                        Console.WriteLine("Constant of class Animal = " + Animal.T);
                        //Animal.T = 200; cannot change constant
                        //dog.R cannot change READONLY
                        int r = dog.R;
                        Console.WriteLine("Readonly of class Animal = " + dog.R);
                        //dog.R = 34; //dog.R cannot change READONLY
                        dog.Print();
                        Animal cow = new Animal("Dolla", "Martyvna", 3, 6.4f);
                        cow.Print();
                        Console.WriteLine("Count of animals = " + Animal.count);
                        //Constructors - for initialisation of objects
                        Student student1 = new Student();
                        //Student student2 = new Student("Helen", 4, false);
                        //Initialisator instead of constructor:
                        Student student2 = new Student { name = "Helen", course = 4, step = false };
                        Console.WriteLine("Course of student1 = " + student1.Course);
                        student1.Course = 2; //change the value of field COurse via SET
                        //program can not set value if it is invalid due to conditions in SET
                        student1.Course1 = 9;
                        student1.Print();
                        student2.Print();
                        Console.WriteLine("New Course of student1 = " + student1.Course);
                        Console.WriteLine("New Course of student1 = " + student1.Course1);
                        Calculator.Add(2, 3);
                        //ClassLibrary1.UserClass user = new ClassLibrary1.UserClass(); or import created Library
                        UserClass user = new UserClass();
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 10: //METHODS, FUNCTIONS, 
                    {//Function is method with no void witch returns something
                        Console.WriteLine("\t\t\tMethods, Functions, ref, out, param, recursion");
                        WriteHello();
                        WriteHello2("Second method with arguments");
                        Console.WriteLine("\t\t\t\tREF parameters, OUT parameters");
                        Console.WriteLine("\t\tREF changes variable - not just copy");
                        Console.WriteLine("\t\tOUT enables to return several results of one function");
                        Console.WriteLine("Enter first number: ");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        Add(n1, n2);
                        Console.WriteLine("N1 is now (doesn't change) = " + n1);
                        int y1 = 9;
                        AddRef(ref y1, 5); //REF changes variable - not just copy, so value of variable will change
                        Console.WriteLine("Y1 is now (changed because of ref) " + y1);
                        int par, area;
                        DataParam(10, 15, out area, out par);
                        int res = Multiply(n1, n2);
                        Console.WriteLine("Result of multiplication = " + res);
                        Console.WriteLine("\t\tUnnecessary parameters");
                        Option(1, 2);
                        Option(1, 2, 3);
                        Option(1, 2, 3, 4);
                        Console.WriteLine("\t\tNamed parameters");
                        Option(s: 1, x: 2, z: 7, y: 9);
                        Console.WriteLine("\t\tPARAMS parameters (unlimited number of parameters)");
                        AdditionPARAMS(new int[] { 1, 2, 3, 4 });
                        AdditionPARAMS(2, 3, 4, 5);
                        AdditionPARAMS();
                        AdditionPARAMS(4, 5);
                        Addition(2, "Hello", 1, 2, 3, 4, 5);
                        //Область видимости класса, метода, блока кода
                        //Переменные метода перекрывают переменные класса
                        Console.WriteLine("\t\tRecursive Functions");
                        Console.WriteLine("Factorial 5 (120) = "+ Factorial(5));
                        Console.WriteLine("Factorial 4 (24) = " + Factorial(4));
                        Console.WriteLine("Fibonachi 8 (21) = " + Fibonachi(8));
                        SayHello();
                        Addition1(1, 2, 3, 4, 5);
                        int[] array = new int[] { 1, 2, 3, 4 };
                        AdditionMas(array, 2);
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 11: //INHERITANCE, AS/IS, Virtual methods (From External Class file)
                    {
                        Console.WriteLine("\t\t\tINHERITANCE (From External Class file), AS/IS, Virtual Methods, Abstract Classes");
                        Dog tom = new Dog(12.23f, "Bob");
                        Console.WriteLine(tom.Name);
                        tom.Name = "Tom";
                        Console.WriteLine(tom.Name);
                        Dog jerry = new Dog(22.22f, "Jerry");
                        Console.WriteLine(jerry.Name);
                        Console.WriteLine();
                        jerry.Print();
                        //Create Massive of pointers (objects) which point on the main Class. 
                        //Type is name of Class - System.Collections.Generic
                        List<Animal1> animals = new List<Animal1> ();
                        animals.Add(new Dog(11.11f, "Alex")); //This object can invoke only methods from main class
                        animals.Add(new Dog(33.11f, "Helena"));
                        animals.Add(new Cat(43.11f, "Mew"));
                        Console.WriteLine("\t\t\tAS/IS");
                        foreach (Animal1 animal in animals)//when we don;t now the number of elements, but can count
                        {
                            if (animal is Animal1)
                            {
                                Console.WriteLine(animal.Name);
                                //IS - exception, AS - returns null
                                Console.WriteLine(animal is Dog); //Does element belong to class?
                            }
                            if (animal is Cat)
                            {
                                Console.WriteLine("Check if cat");
                                Console.WriteLine(animal.Name);
                                (animal as Cat).Print();
                            }
                        }
                        Console.WriteLine("\t\t\tVirtual methods"); //method which can be reinitialised
                        //Needed to be realized in main method, in childs - not obligatory
                        foreach (Animal1 animal in animals) //Переопределение методов (small changes from method in main class)virtual - overwrite in inherited method
                        {
                            animal.Print();
                        }
                        Console.WriteLine("\t\t\tAbstract classes");
                        //Abstract class - isn't needed to execute in main class, because very different in inherited classes
                        //Is obligatory to mention in all inherited classes
                        //We cannot create objects from abstract class
                        //Abstract class can contain abstract or general methods
                        //Inherited class can only contain 1 Abstract class
                        List<Animal2> animals2 = new List<Animal2>();
                        //This object can invoke only methods from main class
                        animals2.Add(new Cat2(43.11f, "Mew"));
                        foreach (Animal2 animal2 in animals2) 
                        {
                            animal2.Print3();
                        }
                        Client client = new Client("Tom", 500);
                        Employee employee = new Employee("Bob", "Apple", "Oracle");
                        client.Display();
                        employee.Display();

                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 12:
                    {//Множественной наследование
                        //Interfaces (like classes) - methods/properties are written in main class, but - realized in other classes(inherited)
                        //In Abstract classes (can contain also general methods/properties) which can be realized in main class
                        //In C# we cannot inhering methods/properties from several other(main) classes (was in C++)
                        //But we can inherit some from several interfaces
                        //Interfaces - enable to inherit info from several classes
                        Console.WriteLine("\t\t\tINTERFACES (multi-inheritance)");
                        Test test_1 = new Test();
                        Test2 test_2 = new Test2();
                        test_1.property = 12;
                        test_1.Print();
                        test_1.Draw();
                        Console.WriteLine(test_1.property);
                        Console.WriteLine();
                        test_2.property = 15;
                        test_2.Print();
                        Console.WriteLine(test_2.property);
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 13:
                    {//Type of parameters of methods should be different, or number of parameters
                        Console.WriteLine("\t\t\tReload of Methods, Reload of Operators, Преобразование типов");
                        SomeReloadMeth test = new SomeReloadMeth();
                        //versions of methods should differ by the number or type of parameters, not ONLY via type of methods - void/int..
                        test.Multiply(2, 23);
                        test.Multiply3(2, 23, 2);
                        test.Multiply(2, 23, 2);
                        test.Multiply(2, 23, 2, 2);
                        test.Multiply("Text from Reload of Method");
                        //Reload of Operators
                        Counter c1 = new Counter { Value = 23 };
                        Counter c2 = new Counter { Value = 11 };
                        int x = c2 + 20;
                        Counter c3 = c1 + c2;
                        Console.WriteLine("Reload of Operator + = " + c3.Value);
                        bool res = c1 > c2;
                        Console.WriteLine("Reload of Operator > = " + res);
                        Counter counter = new Counter() { Value = 0 };
                        if (counter)
                            Console.WriteLine(true);
                        else
                            Console.WriteLine(false);
                        object x8 = null;
                        object y8 = x8 ?? 100;  // равно 100, так как x равен null
                        object z = 200;
                        object t = z ?? 44; // равно 200, так как z не равен null
                        //Reload of Types/Classes
                        Counter counter1 = new Counter { Seconds = 115 };
                        int x1 = (int)counter1; //for explicit
                        Counter counter2 = x1;
                        byte y = (byte)x; //explicit
                         counter1.Seconds = 115;
                        Timer timer1 = counter1;
                        Console.WriteLine($"{timer1.Hours}:{timer1.Minutes}:{timer1.Seconds}");
                        Counter counter3 = (Counter)timer1;
                        Console.WriteLine(counter3.Seconds);
                        Console.WriteLine("INDEXATORS");
                        Team inter = new Team();
                        inter[0] = new Player { Name = "Ronaldo", Number = 9 };
                        inter[1] = new Player { Name = "R. Baggio", Number = 10 };
                        inter[2] = new Player { Name = "Simeone", Number = 8 };
                        Console.WriteLine(inter[1]?.Name);
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 14:
                    {//Enum
                        Console.WriteLine("\t\t\tENUM");
                        //  Animal dog = new Animal("Dog");
                        Animal dog = new Animal(Breed.Tiger);
                        dog.Print();
                        Days day = Days.Tuesday;
                        Console.WriteLine("Day = " + day);
                        Console.WriteLine("Day = " + (int)day);
                        ApplyOperation_enum(10, 15, Oper.Add);
                        ApplyOperation_enum(10, 15, Oper.Multiply);
                        Oper op;
                        op = Oper.Multiply;
                        Console.WriteLine((int)op); // 3;
                        /*char g;
                        do {
                            Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                            g = Convert.ToChar(Console.ReadLine());
                        }
                        while (g != 'Y' || g!='Z');
                        if(g =='Y') goto Content;
                        else
                            goto End;*/
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 15:
                    {//STRUCTURES - take less memory, but cannot contain virtual methods, inheritance, ...
                        Console.WriteLine("\t\t\tSTRUCTURES");
                        Book b;
                        b.author = "King";
                        b.title = "Title name";
                        b.name = "Name of structure";
                        b.Print();
                        Book[] books = new Book[2]; //Massive of structures
                        books[0] = new Book("First author", "Title 1", "Name 1"); //using constructor for structure
                        books[1].author = "Second author";
                        books[1].title = "Title 2";
                        books[1].name = "Name 2";
                        foreach (Book book in books)
                        {
                            book.Print();
                        }
                        Book tom = new Book("Tom", "Tom1", "Tom2");//using constructor for structure
                        tom.Print();
                        User user1 = new User { name = "HANNA", age = 24 };//initialization of objects
                        //objects of STRUCTURE as parameter of method
                        ChangeUser(user1); //doesn't change the initial values of user1
                        Console.WriteLine($"{user1.name}, {user1.age}");
                        ChangeUser1(ref user1);////change the initial values of user1
                        Console.WriteLine($"{user1.name}, {user1.age}");

                        User1 user2 = new User1 { name = "HANNA", age = 24 };
                        //objects of CLASS as parameter of method
                        ChangeUser(user2); //change the initial values of user2, but not via constructor in method
                        Console.WriteLine($"{user2.name}, {user2.age}");
                        ChangeUser1(ref user2);////change the initial values of user2 via constructor in method
                        Console.WriteLine($"{user2.name}, {user2.age}");

                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                        break;
                    }
                case 16:
                    {//Tuples Кортеж
                        Console.WriteLine("\t\t\tTUPLES (Кортежи)");
                        //var tuple1 = (5, 10);
                        (int, int) tuple1 = (5, 10);
                        Console.WriteLine("First Tuple item = " + tuple1.Item1);
                        Console.WriteLine("Second Tuple item = " + tuple1.Item2);
                        tuple1.Item1 += 20;
                        Console.WriteLine("First item + 20 = " + tuple1.Item1);
                        var tuple2 = (count: 55, sum: 100);
                        Console.WriteLine("First Tuple item = " + tuple2.count);
                        Console.WriteLine("SecondTuple item = " + tuple2.sum);
                        var (name, age) = ("Hanna", 24);
                        Console.WriteLine(name);
                        Console.WriteLine(age);
                        //Use Tuple to return several values from function
                        var tuple = GetValTuple();
                        Console.WriteLine(tuple.Item1);
                        Console.WriteLine(tuple.Item2);
                        //Method returns tuple and takes tuple and int
                        var tuple3 = GetValTuple1(("Toma", 25), 10);
                        Console.WriteLine(tuple3.Item1);
                        Console.WriteLine(tuple3.Item2);
                        var tuple5 = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
                        Console.WriteLine(tuple5.count);
                        Console.WriteLine(tuple5.sum);
                        var (name1, age1) = GetTuple(("Tom", 23), 12);
                        Console.WriteLine(name1);    // Tom
                        Console.WriteLine(age1);     // 35


                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                        break;
                    }
                case 17:
                    {//REF
                        int x = 5;
                        ref int xRef = ref x; //xRef points on the same place in memory as variable x
                        Console.WriteLine($"x={x}");
                        Console.WriteLine($"xRef={xRef}");
                        xRef = 125;
                        Console.WriteLine($"x={x}");
                        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
                        ref int nRef = ref Find(numbers, 4);
                        Console.WriteLine(numbers[3]);//4
                        nRef = 45;
                        Console.WriteLine(numbers[3]);//45
                        try {
                            ref int nRef1 = ref Find(numbers, 85);
                            Console.WriteLine(nRef1);
                        }
                        catch(Exception ex) { Console.WriteLine("Error:" + ex.Message); }

                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                        break;
                    }
                case 18:
                    {
                        Console.WriteLine("\t\t\tShadowing / hiding of methods, properties, variables");
                        Person1 bob = new Person1("Bob", "Robertson");
                        bob.Display();      // Bob Robertson

                        Employee tom = new Employee("Tom", "Smith", "Microsoft");
                        tom.Display();      // Tom Smith работает в Microsoft
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 19:
                    {
                        Console.WriteLine("\t\t\tRegular Expressions, File I/O");
                        Console.WriteLine("Searching words that start on M and end on E");
                        string str = "make maze milk and manage to measure it";
                        Console.WriteLine("Matching words start with 'm' and ends with 'e':");
                        showMatch(str, @"\bm\S*e\b");
                        Console.WriteLine("Removing EXTRA spaces");
                        string input = "Hello   World   ";
                        string pattern = "\\s+";
                        string replacement = " ";

                        Regex rgx = new Regex(pattern);
                        string result = rgx.Replace(input, replacement);

                        Console.WriteLine("Original String: {0}", input);
                        Console.WriteLine("Replacement String: {0}", result);


                        FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate,
                        FileAccess.ReadWrite);

                        for (int i = 1; i <= 20; i++)
                        {
                            F.WriteByte((byte)i);
                        }
                        F.Position = 0;
                        for (int i = 0; i <= 20; i++)
                        {
                            Console.Write(F.ReadByte() + " ");
                        }
                        F.Close();
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 20:
                    {
                        Console.WriteLine("\t\t\tPreprocessor Directives");
                        #if (DEBUG && !VC_V10)
                                 Console.WriteLine("DEBUG is defined");
                        #elif (!DEBUG && VC_V10)
                                 Console.WriteLine("VC_V10 is defined");
                        #elif (DEBUG && VC_V10)
                                                Console.WriteLine("DEBUG and VC_V10 are defined");
                        #else
                                 Console.WriteLine("DEBUG and VC_V10 are not defined");
                        #endif
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 21:
                    {
                        Console.WriteLine("\t\t\tNamespaces");
                        first_space.namespace_cl fc = new first_space.namespace_cl();
                        second_space.namespace_cl sc = new second_space.namespace_cl();
                        fc.func();
                        sc.func();
                        abc fc1 = new abc();
                        efg sc1 = new efg();
                        fc1.func();
                        sc1.func();
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
                case 22:
                    {
                        Console.WriteLine("22\t\t\tNullables");
                        int? num1 = null;
                        int? num2 = 45;

                        double? num3 = new double?();
                        double? num4 = 3.14157;

                        bool? boolval = new bool?();

                        // display the values
                        Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
                        Console.WriteLine("A Nullable boolean value: {0}", boolval);
                        double? num11 = null;
                        double? num21 = 3.14157;
                        double num31;

                        num31 = num11 ?? 5.34;
                        Console.WriteLine(" Value of num3: {0}", num31);

                        num31 = num21 ?? 5.34;
                        Console.WriteLine(" Value of num3: {0}", num31);
                        Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
                        char g = Convert.ToChar(Console.ReadLine());
                        if (g == 'Y')
                            goto Content;
                        else
                            goto End;
                    }
            }
        End:
            Console.WriteLine("The End");
            Console.ReadKey();
        }



        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        public static void WriteHello()
        {
            Console.WriteLine("Hello from Write Hello");
        }

        public static void WriteHello2(string str)
        {
            Console.WriteLine(str);
        }

        public static void Add(int n1, int n2)
        {
            n1 = n1 + n2;
            Console.WriteLine("Result of ADD is = " + (n1));
        }

        public static void AddRef(ref int r1, int r2)
        {
            r1 = r1 + r2;
            Console.WriteLine("Result of AddRef is = " + (r1));
        }
        public static void DataParam (int w, int h, out int area, out int param)
        {
            param = (w * h) * 2;
            area = w * h;
            Console.WriteLine($"Area = {area}, Param = {param}");
        }

        public static int Multiply (int n1, int n2)
        {
            return n1 * n2;
        }
        static int Option (int x, int y, int z=5, int s = 7)
        {
            int d = (x + y + z + s);
            Console.WriteLine($"Sum of Option {x}, {y}, {z}, {s} = " + d);
            return d;
        }
        static void AdditionPARAMS (params int[] numbers)
        {
            int res = 0;
            for(int i=0; i < numbers.Length; i++)
            {
                res += numbers[i];
            }
            Console.WriteLine(res);
        }
        static void Addition(int x, string mes, params int[] integers)
        { }
        static int Factorial (int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return n * Factorial(n - 1);
        }
        //F(n)=f(n-1)+f(n-2)
        static int Fibonachi (int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            else return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static void ApplyOperation_enum (double x, double y, Oper ep)
        {
            double res = 0.0;
            switch (ep)
            {
                case Oper.Add:
                    res = x + y;
                    break;
                case Oper.Divide:
                    res = x / y;
                    break;
                case Oper.Multiply:
                    res = x * y;
                    break;
                case Oper.Subtract:
                    res = x - y;
                    break;
            }
            Console.WriteLine($"Result of Operatin {ep} (via enum)" + res);
        }
        static (int, int) GetValTuple() //Method returns tuple
        {
            int res = 1111;
            int res2 = 2222;
            return (res, res2);
        }
        private static (int sum, int count) GetNamedValues(int[] numbers)//For Tuple
        {
            var result = (sum: 0, count: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }
            return result;
        }
        private static (string name, int age) GetTuple((string n, int a) tuple, int x)
        {
            var result = (name: tuple.n, age: tuple.a + x);
            return result;
        }

        static (string, int) GetValTuple1((string, int) tuple, int x) //Method returns tuple and takes tuple and int
        {
            var res = (name: tuple.Item1, age:tuple.Item2+x); 
            return res;
        }
        static ref int Find (int[] numbers, int number)//find element "number" in array "numbers" and return reference on number in array
        {
            for(int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }
            throw new Exception("Number not found");
        }
        static void ChangeUser(User user)
        {
            user.name = "HELEN";
            user.age = 30;
        }
        static void ChangeUser1(ref User user)
        {
            user.name = "HELEN";
            user.age = 30;
        }
        static void ChangeUser(User1 user)
        {
            user.name = "HELEN";
            user.age = 30;
            //user = new User1 { name = "Ludmyla", age = 52 }; will not change initial values
        }
        static void ChangeUser1(ref User1 user)
        {
            user.name = "HELEN";
            user.age = 30;
            user = new User1 { name = "Ludmyla", age = 52 };//will change initial values
        }
        static void SayHello() => Console.WriteLine("Hello SayHello");
        // передача параметра с params
        static void Addition1(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
        // передача массива
        static void AdditionMas(int[] integers, int k)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += (integers[i] * k);
            }
            Console.WriteLine(result);
        }
    }
    class Player
    {
        public string Name { get; set; } // имя
        public int Number { get; set; } // номер
    }
    class Team
    {
        Player[] players = new Player[11];

        public Player this[int index]
        {
            get { return players[index]; }
            set { players[index] = value; }
        }
    }
    class Calculator
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine($"Sum {x} and {y} equals {z}"); //Interpolation of strings
        }
    }
    class Student
    {
        public string name; //fields
        public int course;
        public bool step;
        //we can set a value to automatic property
        public int Course1 { get; set; } = 0;//Automatic Properties (here lice public field) - to simplify
        //public int Course1 { private get; set; } - from Main we can only set value, not read
        //Property: we can overwrite it
        public int Course //Accessors GET/SET instead of public field or methods (conditions in 1 place)
        {
             get
            {
                return course;
            }
             set
            {
                if (value < 1)
                    course = 1;
                if (value > 5)
                    course = 5;
                else
                    course = value;
            }
        }
        public Student()
        {
            name = "Hanna";
            course = 5;
            step = true;
            Print();
        }
        public Student(string name, int course, bool step) : this(name)
        {
            //this.name = name;
            this.course = course;
            this.step = step;
            Print();
        }
        public Student(string name)
        {
            this.name = name;      
        }
        public void Print()
        {//create method for the class
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Course = " + course);
            Console.WriteLine("Scholarship = " + step);
        }
    }
    enum Breed { Dog, Cat, Bird, Tiger}; //ENUM
    enum Time : byte //byte, int, short, long
    {
        Morning,
        Evening
    }
    class Animal //we can create objects for class, object will inherit all properties of class
    { //Модификаторы доступа: public, protected, private. By default = private
        public string name = "Spotty";  //variables=fields
        private string surname = "Bob"; //only for this class
        public int age = 7; //we can get access from ever class
        public const int T = 100; //cannot change constant in main method. Must be initialized on the top, not in constructor
        public readonly int R = 500; //we can change value in constructor
        protected float happiness = 9.99f; //only for subsidiary classes of this class (inheritance)
        public static int count = 0; //Static Field/Property/Method/Constructor - is the same for all objects of class. Static - general state for all objects
        //then we can invoke static method/property by Class.Method, but not object1.Method, object2.Method
        //Static - for ALL objects. We cannot create objects from static class.
        //Class is static if all his elements are static
        //Math. - static class
        //public string breed;
        public Breed breed; //from ENUM
        public Animal() //Constructor has properties for all objects of this class. Like default
        {
            name = "Bob";
            surname = "SurBob";
            age = 8;
            happiness = 10;
            R = 600;
            count++;
            Print();
        }
        //Constructors have to have the same name
        public Animal(string _name, string _surname, int _age, float _happiness) //Constructor has parameters for all objects of this class
        {
            name = _name;
            //this.name = name; this - Variable  of Class
            surname = _surname;
            age = _age;
            happiness = _happiness;
            count++;
            Print();
        }
        // public Animal(string breed)
        public Animal(Breed breed) //ENUM
        {
            this.breed = breed;
        }
        public void Print()
        {//create method for the class
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Surname = " + surname);
            Console.WriteLine("Age = " + age);
            Console.WriteLine("Happiness = " + happiness);
            Console.WriteLine("Breed - " + breed);
        }
        public string Surname //PROPERTY - name as variable of class, but capitalised
        {
            get { return surname; }
            set { surname = value; }
        }
    }
} class Counter
{
    public int Seconds { get; set; }
    //Преобразование типов
    public static implicit operator Counter (int x)//want to change type int to Counter
    {
        return new Counter { Seconds = 150 };
    }
    public static explicit operator int (Counter counter)//want to change type int to Counter
    {
        return counter.Seconds;
    }
    //Преобразование classes
    public static explicit operator Counter(Timer timer)
    {
        int h = timer.Hours * 3600;
        int m = timer.Minutes * 60;
        return new Counter { Seconds = h + m + timer.Seconds };
    }
    public static implicit operator Timer(Counter counter)
    {
        int h = counter.Seconds / 3600;
        int m = (counter.Seconds - h * 3600) / 60;
        int s = counter.Seconds - h * 3600 - m * 3600;
        return new Timer { Hours = h, Minutes = m, Seconds =s};
    }

    public int Value { get; set; }
    //Reload of operators
    public static Counter operator +(Counter c1, Counter c2)
    {
        return new Counter { Value = c1.Value + c2.Value };
    }
    public static int operator +(Counter c1, int x) //the order of parameters - important!
    {
        return  c1.Value + x ;
    }
    public static bool operator >(Counter c1, Counter c2)
    {
        if (c1.Value > c2.Value)
            return true;
        else return false;
    }
    public static bool operator <(Counter c1, Counter c2)
    {
        if (c1.Value > c2.Value)
            return false;
        else return true;
    }
    public static bool operator true(Counter c1)
    {
        return c1.Value != 0;
    }
    public static bool operator false(Counter c1)
    {
        return c1.Value == 0;
    }

}
class Timer
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
}
class Person1 //shadowing / hiding
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    protected string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public Person1(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public readonly int x = 10;
    public const int G = 5;

    public void Display()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}

class Employee : Person1
{
    public string Company { get; set; }
    public new readonly int x = 20;
    public new const int G = 15;
    public new string Name
    {
        get { return "Employee " + base.Name; }
        set { name = value; }
    }
    public Employee(string firstName, string lastName, string company)
            : base(firstName, lastName)
    {
        Company = company;
    }
    public new void Display()
    {
        Console.WriteLine($"{FirstName} {LastName} работает в {Company}");
    }
}
class PersonException : Exception
{
    public PersonException(string message)
        : base(message)
    { }
}

namespace first_space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}
namespace second_space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}
namespace first1_space
{
    class abc
    {
        public void func()
        {
            Console.WriteLine("Inside first1_space");
        }
    }
}
namespace second1_space
{
    class efg
    {
        public void func()
        {
            Console.WriteLine("Inside second1_space");
        }
    }
}


//namespace RectangleApplication
//{
//    class Rectangle
//    {

//        // member variables
//        double length;
//        double width;

//        public void Acceptdetails()
//        {
//            length = 4.5;
//            width = 3.5;
//        }
//        public double GetArea()
//        {
//            return length * width;
//        }
//        public void Display()
//        {
//            Console.WriteLine("Length: {0}", length);
//            Console.WriteLine("Width: {0}", width);
//            Console.WriteLine("Area: {0}", GetArea());
//        }
//    }
//    class ExecuteRectangle
//    {
//        static void Main(string[] args)
//        {
//            Rectangle r = new Rectangle();
//            r.Acceptdetails();
//            r.Display();
//            Console.ReadLine();
//        }
//    }
//}



