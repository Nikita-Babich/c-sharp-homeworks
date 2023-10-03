namespace pred2
{
    /*
    internal class Student //trieda Student ktora ma dve premenne
    {
        public string name; //public znamena, ze viem do premenej priamo pristupit z triedy Program a z funckie Main
        public int grade;
    }
    */
    /*
    internal class Student1
    {
        private string name; //private znamena, ze k premennej viem pristupit iba v triede Student1
        private int grade;


        public Student1(string n, int grade) //public konstruktor
        {
            name = n;
            this.grade = grade;
        }


        public string getName() //C++ sposob na vratenie hodnoty
        {
            return name;
        }


        public string Name   //C# sposob, nazov funckie moze byt lubovolny, standard je vsak pouzit rovnaky nazov ako ma premenna len s prvym pismenom velkym
        {
            get { return name; }   // vratenie premennej
            set { name = value; }  // nastavene premennej
        }


        public int Grade { get => grade; set => grade = value; }
        //public int Grade { get; set; }
    }
    */


    /*internal class bigMemoryClass
    {
        public double[] array;


        public bigMemoryClass()
        { array = new double[100000000]; } //Konstruktor alokuje velke pole
    }*/


    internal class Program
    {
        private static void Main(string[] args)
        {
            /*


            var number = 10; //pocas kompilovania za var sa automaticky doplni int (resp. System.Int32 co je to iste)
            var text = "Cislo"; //za var sa doplni string
            Console.WriteLine($"{text} = {number} ");
            */


            /*
            dynamic variable = 1; //datovy typ sa priradi pocas "behu" programu
            Console.WriteLine($"{variable}");
            variable = "text"; //datovy typ viem hocikedy zmenit
            Console.WriteLine($"{variable}");
            variable = new int[5] { 1, 2, 3, 4, 5 }; //dokonca ho viem zmenit aj na pole
            Console.WriteLine($"{variable[4]}");
            */


            /*
            var student = new { Id = 1, Name = "Student" }; //anonymny datovy typ, skoro ako struktura v C/C++
            dynamic variable2 = student;
            Console.WriteLine($"{variable2.Id} {variable2.Name}");
            //variable2.Id = 2; //anonymny datovy typ je iba na ciatanie, nemozem zmenit hodnoty, program spadne
            */


            /*Student student = new Student();
            student.name = "Student";
            student.grade = 1;
            Console.WriteLine($"{student.name} ma znamku {student.grade}");
            */


            /*
            Student1 student1 = new Student1("Student", 1); //konstruktor s parametrami


            Console.WriteLine($"{student1.getName()}"); //C++ sposob na ziskanie premennej name


            Console.WriteLine($"{student1.Name}"); //C# sposob na ziskanie premennej name
            student1.Name = "New student"; //C# sposob na nastavenie premmenj name
            Console.WriteLine($"{student1.Name}");
            student1.Grade = 2;
            Console.WriteLine($"{student1.Grade}");
            */


            /*
            bigMemoryClass memory = new bigMemoryClass();
            for (int i = 0; i < 10; i++) //Potrebujem kompilatoru ukazat, ze s polom pracujem, inak ho odignoruje
            {
                Console.WriteLine($"{memory.array[i]}");
            }
            Console.WriteLine();
            memory = null; //automaticky sa zavola garbage collector, aj bez nutnosti destructora sa mi pole dealokue


            Console.WriteLine();
            */


            /*
            StreamWriter write = new StreamWriter("text.txt", false); //Zapis do textoveho suboru
            write.WriteLine("Test text...");
            write.Close();
            */


            /*
            using (StreamWriter write2 = new StreamWriter("text.txt", false)) //Citanie z textoveho suboru
            {
                write2.WriteLine("10");
                for (int i = 0; i < 10; i++)
                {
                    write2.WriteLine($"{i}");
                }
            }*/


            /*
            int[] fileArray;
            using (StreamReader read = new StreamReader("text.txt")) //Citanie cisiel z textoveho suboru
            {
                fileArray = new int[Convert.ToInt32(read.ReadLine())];
                for (int i = 0; i < 10; i++)
                {
                    fileArray[i] = Convert.ToInt32(read.ReadLine());
                }
            }


            for (int i = 0; i < fileArray.Length; i++)
            {
                Console.WriteLine(fileArray[i]);
            }
            */


            /*
            int[][] jArray = new int[10][]; //nerovnomerne pole
            for (int i = 0; i < jArray.Length; i++)
            {
                jArray[i] = new int[i + 1];
                for (int j = 0; j < jArray[i].Length; j++)
                {
                    jArray[i][j] = i + 1;
                }
            }


            for (int i = 0; i < jArray.Length; i++)
            {
                for (int j = 0; j < jArray[i].Length; j++)
                {
                    Console.Write(jArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            */
        }
    }
}