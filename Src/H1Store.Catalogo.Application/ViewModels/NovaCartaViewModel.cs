﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.ViewModels
{
    public class NovaCartaViewModel
    {

       [Required(ErrorMessage = "Nome obrigatorio")]
       [MinLength(3, ErrorMessage = "O nome deve ter no minimo 3 caracteres")]
       [MaxLength(255, ErrorMessage = "O nome deve ter no maximo 255 caracteres")]
       public string NomeCrianca { get; set; }

       [Required(ErrorMessage = "O nome da Rua do endereco da crianca e necessario")]
       [MinLength(3, ErrorMessage = "A rua deve ter no minimo 3 caracteres")]
       [MaxLength(255, ErrorMessage = "A rua deve ter no maximo 255 caracteres")]
       public string Rua { get; set; }

       [Required(ErrorMessage = "O nome do Bairro do endereco da crianca e necessario")]
        [MinLength(3, ErrorMessage = "O Bairro deve ter no minimo 3 caracteres")]
        [MaxLength(255, ErrorMessage = "O Bairro deve ter no maximo 255 caracteres")]
        public string Bairro { get; set; }

       [Required(ErrorMessage = "O nome da Cidade do endereco da crianca e necessario")]
        [MinLength(3, ErrorMessage = "A cidade deve ter no minimo 3 caracteres")]
        [MaxLength(255, ErrorMessage = "A cidade deve ter no maximo 255 caracteres")]
        public string Cidade { get; set; }

       [Required(ErrorMessage = "O nome do Estado do endereco da crianca e necessario")]
        [MinLength(3, ErrorMessage = "O Estado deve ter no minimo 3 caracteres")]
        [MaxLength(255, ErrorMessage = "O Estado deve ter no maximo 255 caracteres")]

        public string Estado { get; set; }

       [Required(ErrorMessage = "O numero da casa da crianca e necessario")]
       public int Numero { get; set; }

       [Required(ErrorMessage = "A idade da crianca e necessario")]
       [Range(3, 15, ErrorMessage = "Deve ter uma idade entre 3 e 15 anos")]
       public int Idade { get; set; }

       [Required(ErrorMessage = "O texto da carta da crianca e necessario")]
       [MaxLength(500, ErrorMessage = "O texto da carta não pode ter mais de 500 caracteres.")]
       public string TextoCarta { get; set; }
    }
}
