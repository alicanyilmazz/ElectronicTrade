
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Subject { get; set; }     
        public string Text { get; set; }
        public string UserBy { get; set; }
        public bool IsRead { get; set; }      
        public int? Member_From_Id { get; set; }      
        public int? Member_To_Id { get; set; }
        public int? Parent_Message_Id { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Member sendedmember { get; set; }
        public Member takedmember { get; set; }
        public Message message { get; set; }
        public List<Message> messages { get; set; }
    }
}
