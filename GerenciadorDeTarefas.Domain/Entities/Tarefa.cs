using GerenciadorDeTarefas.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Domain.Entities
{
    public class Tarefa
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataVencimento { get; set; }
        public StatusTarefa Status { get; set; }
        public PrioridadeTarefa PrioridadeTarefa { get; set; }

        public Guid IdProjeto { get; set; }
        public Guid IdUsuario { get; set; }

        #region Relacionamentos

        public Projeto Projeto { get; set; } = null!;
        public Usuario Usuario { get; set; } = null!;
        public List<Comentario>? Comentarios { get; set; }
        public List<TarefaHistorico>? HistoricoTarefas { get; set; }

        #endregion
    }
}
