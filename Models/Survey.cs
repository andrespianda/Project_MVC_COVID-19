using System;
using System.ComponentModel.DataAnnotations;



namespace Project_COVID_19.Models
{
    public class Survey
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public string Tipo_Id { get; set; }

        [Required]
        public string NIdentificacion { get; set; }

        [Required]
        public string tipo_servicio { get; set; }        
        
        [Required]
        public string EncargadoEncuesta { get; set; }

        [Required]
        public string Tipo_atencion { get; set; }


        [Required]
        public string ServicioEncargado { get; set; }

        [Required]
        public char sintomas1 { get; set; }

        [Required]
        public char sintomas2 { get; set; }

        [Required]       
        public char sintomas3 { get; set; }

        [Required]
        public char sintomas4 { get; set; }

        [Required]
        public char sintomas5 { get; set; }

        [Required]
        public char sintomas6 { get; set; }
        
        [Required]       
        public char sintomas7 { get; set; }
        
        [Required]                
        public char sintomas8 { get; set; }

        [Required]                
        public char sintomas9 { get; set; }
        
        [Required]                
        public char sintomas10 { get; set; }

                [Required]                
        public char sintomas11 { get; set; }

                [Required]                
        public char sintomas12 { get; set; }

                [Required]                
        public char sintomas13 { get; set; }

                [Required]                
        public char sintomas14 { get; set; }

                [Required]                
        public string sintomas15 { get; set; }

        [DataType(DataType.Date), Required]
        public DateTime Date { get; set; }  

   
     }
}
