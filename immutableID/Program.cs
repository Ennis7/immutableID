namespace immutableID;
class Program
{
    class Student
    {
        // auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }

    }

    static void Main(string[] args)
    {
        Student student1 = new Student(1, "Willy", "Wonka");
        Console.Write($"\nID:{student1.Id} \nFirst Name: {student1.FirstName} \nLast Name: {student1.LastName}");
        Console.WriteLine();
        Student student2 = new Student(2, "Mary", "Poppins");
        Console.Write($"\nID:{student2.Id} \nFirst Name: {student2.FirstName} \nLast Name: {student2.LastName}");
        Console.ReadKey();
    }
}

