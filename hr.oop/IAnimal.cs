namespace hr.oop
{
    public interface IAnimal
    {
        int id { get; set; }
        string name { get; set; }
        int age { get; set; }
        int sortOrder { get; set; }

        void print();
    }
}
