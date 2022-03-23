using CRUDSQLite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CRUDSQLite.Controllers{
    public class PessoasController : Controller{
        private readonly Context _context;
        public PessoasController(Context context){
            _context = context;
        }
        public async Task<IActionResult> Index(){
            return View(await _context.Pessoas.ToListAsync());
        }
        [HttpGet]
        public IActionResult CriarPessoa(){
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CriarPessoa(Pessoa pessoa){
            await _context.Pessoas.AddAsync(pessoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> EditarPessoa(int id){
            Pessoa pessoa = await _context.Pessoas.FindAsync(id);
            return View(pessoa);
        }
        [HttpPost]
        public async Task<IActionResult> EditarPessoa(Pessoa pessoa){
            _context.Pessoas.Update(pessoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> ExcluirPessoa(int id){
            Pessoa pessoa = await _context.Pessoas.FindAsync(id);
            return View(pessoa);
        }
        [HttpPost]
        public async Task<IActionResult> ExcluirPessoa(Pessoa pessoa){
            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public ActionResult Details(int? id){
            var pessoa = _context.Pessoas.Find(id);
            return View(pessoa);
        }
    }
}
