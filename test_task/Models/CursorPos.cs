
namespace test_task.Models
{
    public record class CursorPos
    {
        public Guid id { get; set;}
        public int x { get; set;}
        public int y { get; set;}
        
        public DateTime time { get; set; }
    }
}
