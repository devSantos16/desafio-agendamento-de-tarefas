using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_agendamento_de_tarefas.Models
{
    public enum TipoStatus
    {
        Tudo,
        Ativo,
        Desativado
    }
    public class Tarefa
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public TipoStatus Status { get; set; }

    }
}