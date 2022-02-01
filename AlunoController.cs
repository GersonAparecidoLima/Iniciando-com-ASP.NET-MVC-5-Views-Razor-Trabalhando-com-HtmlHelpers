using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Paramentro.Models;

namespace Paramentro.Controllers
{
    public class AlunoController : Controller
    {
        //Criando uma Rota especifica
        // https:/ /localhost:44369/novo-aluno
        [Route(template:"novo-aluno")]
        // GET: Aluno
        //Neste momento o papel da Action
        //Aqui temos uma tranforamção um modo byde 'Aluno aluno' 
        //e como se fosse o dado do formulario, que vai sendo passado por paramentro

        // A model e validada na hora que e passada no paramentro
        // public ActionResult Novo(Aluno aluno)
        //Aluno aluno => modo byde
        public ActionResult NovoAluno(Aluno aluno)
        {
            // Se a moden stati não estiver valido
            // ele vai devolver dizendo o que esta erra
            // caso esteja correto retorna a View(aluno)
            if (!ModelState.IsValid)
            // ModelState e o estado da Model, se ela esta valida
            // caso o mode estiver validado em ok
            // retorno TRUE
            {
                // nsete momento nos não vamos implementar a View ainda
                // mas vamos simular um senario real
                return View(aluno);
            }
            return View(aluno);
        }
    }
}