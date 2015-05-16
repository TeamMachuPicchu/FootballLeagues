namespace FootballLeagues.Data.Models
{
    using Contracts;

    public class Tag : BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
