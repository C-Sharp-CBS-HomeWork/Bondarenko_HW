using Task_2.Entity;

namespace Task_2
{
    public class Program
    {
        public static void Main()
        {
            using Task2DBContext DB = new Task2DBContext();

            FirstEntity first = new FirstEntity();
            SecondEntity second = new SecondEntity();
            ThirdEntity third = new ThirdEntity();

            first.Seconds = new List<SecondEntity>{second};
            first.Thirds = new List<ThirdEntity>{third};

            second.Firsts = new List<FirstEntity> {first};
            second.Thirds = new List<ThirdEntity> {third};

            third.Firsts = new List<FirstEntity> {first};
            third.Seconds = new List<SecondEntity> {second};

            //DB.Add(first);
            //DB.Add(second);
            //DB.Add(third);

            //DB.SaveChanges();
        }
    }
}
