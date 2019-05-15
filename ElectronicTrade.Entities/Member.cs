
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Surname { get; set; }   
        public string Email { get; set; }    
        public string Biography { get; set; }     
        public string ProfileImageName { get; set; }
        public string UserBy { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public List<Address> addresses { get; set; }    
        public List<Order> orders { get; set; }       
        public List<Comment> comments { get; set; }      
        public List<Message> incomingmessages { get; set; } 
        public List<Message> outgoingmessages { get; set; }  
    }
}
