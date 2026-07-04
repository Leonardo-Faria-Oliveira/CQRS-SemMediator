namespace SemMediator.Domain.Shared.Records
{
    public record class Log
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Details {  get; set; } = string.Empty;

        public Log(string id)
        {
            Id = id;
        }
        
        public Log(string id, string name)
        {
            Id = id;
            Name = name;
        }
        
        public Log(string id, string name, string details)
        {
            Id = id;
            Name = name;
            Details = details;
        }
    }
}
