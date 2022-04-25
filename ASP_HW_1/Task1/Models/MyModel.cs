namespace Task1.Models
{
    public class MyModel
    {
        public MyModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; } = "Check";
    }
}
