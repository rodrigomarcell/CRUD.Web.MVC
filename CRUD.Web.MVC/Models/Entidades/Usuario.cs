using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Web.MVC.Models.Entidades
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Description = "Código")]
        public int Id { get; set; }

        [Display(Description = "Nome do usuário")]
        public string NomeUsuario { get; set; }
        
        [Display(Description = "Idade")]
        public int Idade { get; set; }

        [Display(Description = "Tipo de usuário")]
        [Column("TIPO")]
        public int Tipo { get; set; }

    }
}
