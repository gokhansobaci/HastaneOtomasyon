using System;

namespace HastaneOtomasyon.Hasta.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;
        public bool Deleted { get; set; } = false;
    }
}
