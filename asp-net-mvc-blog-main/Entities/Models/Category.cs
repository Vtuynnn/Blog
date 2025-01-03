namespace Entities.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Color{get;set;}
        public ICollection<Post>? Posts { get; set; } 
    }
}