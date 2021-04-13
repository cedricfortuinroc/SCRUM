using System;
using System.ComponentModel.DataAnnotations;

namespace RazorSport.Models
{
    public class Atleet
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        
        [DataType(DataType.Date)]
        public DataType Geboortedatum { get; set; }

        public string Nationaliteit { get; set; }
    }
}