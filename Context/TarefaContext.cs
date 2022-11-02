using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using desafio_agendamento_de_tarefas.Models;

namespace desafio_agendamento_de_tarefas.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}