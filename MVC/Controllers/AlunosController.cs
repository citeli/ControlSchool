using System.Net;
using System.Web.Mvc;
using Aplicacao.Interfaces;
using Dominio.Entidades;

namespace MVC.Controllers
{
    [Authorize(Roles = "Administradores")]
    public class AlunosController : Controller
    {
        //private DataContext db = new DataContext();
        private readonly IAlunoAppServico _alunoAppServico;

        public AlunosController(IAlunoAppServico alunoAppServico)
        {
            _alunoAppServico = alunoAppServico;
        }

        // GET: Alunos
        public ActionResult Index()
        {
            return View(_alunoAppServico.BuscaTodos());
        }

        // GET: Alunos/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno aluno = _alunoAppServico.BuscaPorId(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        // GET: Alunos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Matricula,Nome,SobreNome,Cpf,Rg,DataNascimento,Email,NumeroTelefone,NumeroCelular,DataCadastro,Endereco")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _alunoAppServico.Adiciona(aluno);
                return RedirectToAction("Index");
            }

            return View(aluno);
        }

        // GET: Alunos/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno aluno = _alunoAppServico.BuscaPorId(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        // POST: Alunos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _alunoAppServico.Atualiza(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        // GET: Alunos/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno aluno = _alunoAppServico.BuscaPorId(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aluno aluno = _alunoAppServico.BuscaPorId(id);
            _alunoAppServico.Exclui(aluno);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _alunoAppServico.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
