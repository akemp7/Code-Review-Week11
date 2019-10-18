using System.Collections.Generic; 

namespace HairSalon.Models
{
    public class Client
    {
        public string Name { get; set; }
        public int ClientId { get; set; }
        // public virtual ICollection<Cuisine> Cuisines { get; set; } //this is not necessary?
        public int StylistId { get; set; }
        public virtual Stylist Stylist { get; set; }
    }
}