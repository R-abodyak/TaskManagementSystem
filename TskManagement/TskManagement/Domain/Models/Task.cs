namespace TskManagement.Domain.Models;

public class Task
{
   public int Id { get; set; }
   public required string Title { get; set; }
   public string Description { get; set; }
   public DateTime CreatedAt { get; set; }
   public DateTime DueDate { get; set; }
   public IEnumerable<User> AssignedUsers { get; set; }
   public Status Status { get; set; }
}