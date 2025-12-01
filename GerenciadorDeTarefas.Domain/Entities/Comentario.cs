using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Domain.Entities
{
    public class Comentario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid IdTarefa { get; set; }
        public Guid IdUsuario { get; set; }
        public string Conteudo { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}
