using System;

namespace AppPrivy.Domain.Entities
{
    public abstract class Entity
    {
        private string _identificadorUnico;
        private DateTime? _dataCadastro;

        public Entity()
        {
            this._identificadorUnico = Guid.NewGuid().ToString();
            this._dataCadastro = DateTime.Now;
        }

        public DateTime? DataCadastro { get => _dataCadastro; set => _dataCadastro = value; }
        public string IdentificadorUnico { get => _identificadorUnico; set => _identificadorUnico = value; }
    }
}