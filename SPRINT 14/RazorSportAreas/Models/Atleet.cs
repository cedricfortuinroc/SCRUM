using System;
using System.ComponentModel.DataAnnotations;

namespace RazorSportAreas.Models
{
    public class Atleet
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }
        
        public string Nationaliteit { get; set; }
    }
}