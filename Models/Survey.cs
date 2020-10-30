using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_COVID_19.Models
{
    public class Survey
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string AttentionType { get; set; }

        [Required]
        public string ServiceType { get; set; }

        [Required]
        public bool FirstAnswer { get; set; }

        [Required]
        public bool SecondAnswer { get; set; }

        [Required]
        public bool ThirdAnswer { get; set; }

        [Required]
        public bool FourthAnswer { get; set; }

        [Required]
        public bool FifthAnswer { get; set; }

        [Required]
        public bool SixthAnswer { get; set; }

        [Required]
        public bool EighthAnswer { get; set; }

        [Required]
        public bool NinthAnswer { get; set; }

        [Required]       
        public bool TenthAnswer { get; set; }

        [Required]
        public bool EleventhAnswer { get; set; }

        [Required]
        public bool TwelfthAnswer { get; set; }

        [Required]
        public bool ThirteenthAnswer { get; set; }
        
        [Required]       
        public bool FourteenthAnswer { get; set; }
        
        [Required]                
        public string Comment { get; set; }

        [DataType(DataType.Date), Required]
        public DateTime Date { get; set; }        
     }
}
