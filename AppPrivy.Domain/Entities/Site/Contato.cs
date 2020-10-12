using System;

namespace AppPrivy.Domain
{
    public class Contato
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public int Assunto { get; set; }

        public int TipoContato { get; set; }

        public string Mensagem { get; set; }

        public bool Novidades { get; set; }

        public DateTime? DataCadastro { get; set; }
    }
}
