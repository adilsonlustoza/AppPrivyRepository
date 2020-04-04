using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace AppPrivy.Application.ViewsModels
{
    public class ContatoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome deve ser preenchido.")]
        [MinLength(3, ErrorMessage = "O nome de possuir ao menos 3 letras.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "E-mail deve ser preenchido.")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Telefone invalido.")]
        [Required(ErrorMessage = "Telefone é requerido.")]
        public string Telefone { get; set; }


        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "Selecione o assunto")]
        public EnumTipoContato? TipoContato { get; set; }

        [Display(Name = "Assunto")]
        [Required(ErrorMessage = "Assunto deve ser preenchido.")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "Mensagem deve ser preenchida.")]
        [MinLength(30, ErrorMessage = "Mímino de 30 caracteres")]
        [MaxLength(1500, ErrorMessage = "Máximo de 1500 caracteres")]
        [DataType(DataType.MultilineText)]
        public string Mensagem { get; set; }

        public bool Novidades { get; set; }

        //[Display(Name = "Arquivo (*.pdf)")]
        //[DataType(DataType.Upload, ErrorMessage = "Você deve selecionar um arquivo.")]
        //public HttpPostedFileBase File { get; set; }




    }


    public enum EnumAssunto : int
    {
        [Display(Name = "Entrevista")]
        Sugestao = 1,

        [Display(Name = "Orcamento")]
        Reclamacao = 2,

        [Display(Name = "Sugestão")]
        Elogio = 3,

        [Display(Name = "Dúvida")]
        Duvida = 4

    }

    public enum EnumTipoContato : int
    {
        [Display(Name = "Leitor")]
        Leitor = 1,

        [Display(Name = "Empresa")]
        Empresa = 2

    }
}
