namespace EFCodeFirst.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string Line1 { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}
