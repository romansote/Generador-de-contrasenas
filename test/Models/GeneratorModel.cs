using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace test.Models
{


    public enum TypePassword
    {
        OnlyAlphaNumeric = 1,
        OnlyNumbers = 2,
        OnlyLetters = 3,
        AlphanumericAndSpecialSymbols = 4
    }

    public class GeneratorModel
    {
        [Required(ErrorMessage = "El campo Tipo es requerido", AllowEmptyStrings = false)]
        //[Range(0, 4, ErrorMessage = "No existe esta categoria")]
        public int Type { get; set; }

        [Required(ErrorMessage ="El campo Tamaño es requerido", AllowEmptyStrings = false)]
        [Range(0, 99, ErrorMessage = "El largo de la contraseña no puede ser mayor a 99")]
        public int Size { get; set; }

    }

}
