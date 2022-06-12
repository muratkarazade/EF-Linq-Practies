namespace LinqPracties.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            using (var context = new LinqDbContext())
            {
                if(context.Students.Any()) //Hiç student içerisinde veri var mı sorgusu
                {
                    return;
                }

                context.Students.AddRange
                (
                    new Student()
                    {
                       
                        Name = "Bilbo",
                        Surname = "Baggins",
                        ClassId = 1
                    },
                    new Student()
                    {
                     
                        Name = "Frodo",
                        Surname = "Baggins",
                        ClassId = 1
                    },
                    new Student()
                    {
                       
                        Name = "Thorin",
                        Surname = "Oakenshield",
                        ClassId = 2
                    },
                    new Student()
                    {
                     
                        Name = "Gandalf",
                        Surname = "Greyhame",
                        ClassId = 1
                    }
                );
                context.SaveChanges();
            }
        }
    }
}