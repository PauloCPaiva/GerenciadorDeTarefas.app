using GerenciadorDeTarefas.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Domain.Entities
{
    public class Projeto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public Guid IdUsuario { get; set; }

        #region Relacionamentos

        public List<Tarefa> Tarefas { get; set; } = new();
        public Usuario? Usuario { get; set; } 

        #endregion

        public const int LimiteMaximoTarefas = 20;

        public bool PodeAdicionarTarefa()
        {
            return Tarefas.Count < LimiteMaximoTarefas;
        }

        public bool PossuiTarefasPendentes()
        {
            return Tarefas.Any(t => t.Status == StatusTarefa.Pendente || t.Status == StatusTarefa.EmAndamento);
        }
    }
}
