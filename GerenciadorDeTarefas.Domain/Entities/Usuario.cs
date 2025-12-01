using GerenciadorDeTarefas.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public TipoUsuario Tipo { get; set; }

        #region Relacionamentos

        public List<Projeto>? Projetos { get; set; }

        #endregion
    }
}
