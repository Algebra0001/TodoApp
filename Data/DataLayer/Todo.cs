namespace DataLayer
{
  
        public class Todo
        {
            public int Id { get; set; }
            public string TASK { get; set; } = null!;
            public DateTime DueDate { get; set; }
            public bool IsDone { get; set; }
        }
    
}