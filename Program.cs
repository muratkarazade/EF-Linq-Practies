using LinqPracties.DbOperations;

namespace LinqPracties
{
     class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students =_context.Students.ToList<Student>();


            //find()
            Console.WriteLine("****  Find  *****");
            // İlk veriyi getirmek için
            var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault(); 
            student = _context.Students.Find(1);
            Console.WriteLine(student.Name);


            Console.WriteLine("***********************************************************************");
            //FirstOrDefault()
            Console.WriteLine("****  FirstOrDefault  *****");

            Console.WriteLine("1. Yöntem");
            student = _context.Students.Where(student => student.Surname == "Baggins").FirstOrDefault();
            Console.WriteLine(student.Name);

            Console.WriteLine("2. Yöntem");
            student = _context.Students.FirstOrDefault(x => x.Surname == "Baggins");
            Console.WriteLine(student.Name);


            Console.WriteLine("***********************************************************************");
            //SingleOrDefault()
            Console.WriteLine("****  SingleOrDefault  *****");
            //Aranılan veriden sadece 1 tane olması beklenir!
            student = _context.Students.SingleOrDefault(student => student.Name == "Bilbo");
            Console.WriteLine(student.Surname);



            Console.WriteLine("***********************************************************************");
            //ToList()
            Console.WriteLine("****  ToList  *****");
            var studentList =_context.Students.Where(student => student.ClassId == 1).ToList();
            Console.WriteLine("Eleman sayısı: "+studentList.Count);
            foreach (var item in studentList)
            {
                Console.WriteLine(  item.StudentId  + " " +item.Name);
            }


            Console.WriteLine("***********************************************************************");
            //OrderBy()
            Console.WriteLine("****  OrderBy  *****");
            students = _context.Students.OrderBy(x => x.StudentId).ToList();
            foreach (var item in students)
            {
                Console.WriteLine(item.StudentId + " - " + item.Name + " " + item.Surname);
            }



            Console.WriteLine("***********************************************************************");
            //OrderByDescending()
            Console.WriteLine("****  OrderByDescending  *****");
            students = _context.Students.OrderByDescending(x => x.StudentId).ToList();
            foreach (var item in students)
            {
                Console.WriteLine(item.StudentId + " - " + item.Name + " " + item.Surname);
            }


             Console.WriteLine("***********************************************************************");
            //Anonymous Object Result
            Console.WriteLine("****  Anonymous Object Result  *****");

            var anonymousObject = _context.Students
                                .Where(x => x.ClassId == 1)
                                .Select(x => new 
                                {
                                    Id = x.StudentId,
                                    FullName = x.Name + " " + x.Surname

                                });

            foreach (var item in anonymousObject)
            {
                Console.WriteLine(item.Id + " = " + item.FullName);
            }
        }
    }
}