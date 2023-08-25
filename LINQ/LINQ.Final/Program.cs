namespace LINQ.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));

            Console.ReadKey();
        }
        static string[] GetAllStudents(Classroom[] classes)
        {
            return (from n in classes
                    from s in n.Students
                    orderby s
                    select s).ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}