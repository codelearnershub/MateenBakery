namespace BakeryManagementSystem.Models
{
    public class Message : BaseEntity
    {
        
        public string Title {get; set;}
        public int UserId {get; set;}
        public string Content {get;set;}

        public int ReceiverId {get;set;}
        
        public string Reciver {get;set;}
    }
}