using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        [Required(ErrorMessage="O campo {0} é obrigatório."),
        StringLength(50, MinimumLength=3, ErrorMessage="Intervalo permitido de 3 a 50 caracteres.")]
        // [Minlength(3, ErrorMessage="{0} deve ter no mínimo 4 caracteres.")],
        // [Maxlength(50, ErrorMessage="{0} deve ter no máximo 50 caracteres.")]        
        public string Tema { get; set; }
        [Range(1,120000, ErrorMessage="{0} Não pode ser menor que 1 e maior que 120.000.")]
        public int QtdPessoas { get; set; }        
        public string ImagemURL { get; set; }       
        [Required(ErrorMessage="O campo {0} é obrigatório.")]
        [Phone(ErrorMessage="O campo {0} é inválido.")]
        public string Telefone { get; set; }         
        [Required(ErrorMessage="O campo {0} é obrigatório.")]
        [Display(Name="e-mail")]
        [EmailAddress(ErrorMessage="O campo {0} precisa ser um e-mail válido.")]
        public string Email { get; set; }

        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }

    }
}