using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_agendamento_de_tarefas.Context;
using desafio_agendamento_de_tarefas.Models;
using Microsoft.AspNetCore.Mvc;

namespace desafio_agendamento_de_tarefas.Controllers
{
    public class TarefaController : Controller
    {

        private readonly TarefaContext context;

        public TarefaController(TarefaContext context)
        {
            this.context = context;
        }

        public ActionResult Index()
        {
            return View(this.context.Tarefas.ToList());
        }

        public ActionResult Criar()
        {
            return View();
        }
        public ActionResult Editar(int id)
        {
            var t = this.context.Tarefas.Find(id);
            if (t == null)
                return RedirectToAction(nameof(Index));
            return View(t);
        }

        public ActionResult Deletar(Tarefa tarefa)
        {
            var t = this.context.Tarefas.Find(tarefa.Id);
            this.context.Tarefas.Remove(t);
            this.context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public ActionResult Criar(Tarefa tarefa)
        {
            this.context.Tarefas.Add(tarefa);
            this.context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public ActionResult Editar(Tarefa tarefa){
            var t = this.context.Tarefas.Find(tarefa.Id);
            
            t.Titulo = tarefa.Titulo;
            t.Descricao = tarefa.Descricao;
            t.Data = tarefa.Data;
            t.Status = tarefa.Status;

            this.context.Update(t);
            this.context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}