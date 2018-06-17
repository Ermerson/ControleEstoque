using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleEstoque.web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O campo Usuário é Obrigatório")]
        [Display(Name= "Usuário")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "O campo Senha é Obrigatório")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Lembrar Me")]
        public bool LembrarMe { get; set; }
    }
}