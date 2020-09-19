using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ParcialLuisAvila.Models
{
    public class Paises
    {
       
        [Required]
        

        public string name { get; set; } //1

        public enum RegionalBloc 
        {
            EU,
            EFTA,
            CARICOM,
            PA,
            AU,
            USAN,
            EEU,
            CAIS,
            NAFTA
        }
        [Required]
        public RegionalBloc region { get; set; }  //2
            
       
        [Required]
        [DisplayName("Los 3 primeros codigos")]
        [StringLength(3, ErrorMessage ="Espacio requerido es de 3 caracteres", MinimumLength =2)]

        public string alpha3Code { get; set; }   //4
        
        [Key]
        public int area { get; set; } 

        public int  CallingCodes { get; set; }

        [Required]
        [DisplayName("Language")]
        public string Language { get; set; }  //6


    }
}