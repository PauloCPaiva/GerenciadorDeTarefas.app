using GerenciadorDeTarefas.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Domain.Entities
{
    public class TarefaHistorico
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string DescricaoAlteração { get; set; } = string.Empty;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

        public Guid TarefaId { get; set; }
        public Guid UsuarioId { get; set; }

        #region Relacionamentos

        public Tarefa Tarefa { get; set; } = null!;
        public Usuario Usuario { get; set; } = null!;

        #endregion
    }
}
