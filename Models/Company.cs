using System;

namespace webapisqlite.Models
{
    public class Company
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string OwnerName { get; set; }

        public string OwnerEmail { get; set; }
    }
}