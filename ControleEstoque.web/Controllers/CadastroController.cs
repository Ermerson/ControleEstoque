using ControleEstoque.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoque.web.Controllers
{
    public class CadastroController : Controller
    {
        public static List<GrupoProdutoModel> _ListaGrupoProduto = new List<GrupoProdutoModel>()
        {
            new GrupoProdutoModel() {Id=1, Nome="Livros", Ativo=true},
            new GrupoProdutoModel() {Id=2, Nome="Mouse", Ativo=true},
            new GrupoProdutoModel() {Id=3, Nome="Teclado", Ativo=false},
        };
        public ActionResult GrupoProduto()
        {
            return View(_ListaGrupoProduto);
        }

        public ActionResult MarcaProduto()
        {
            return View();
        }

        public ActionResult LocalProduto()
        {
            return View();
        }

        public ActionResult UnidadeMedida()
        {
            return View();
        }

        public ActionResult Produto()
        {
            return View();
        }

        public ActionResult Pais()
        {
            return View();
        }

        public ActionResult Estado()
        {
            return View();
        }

        public ActionResult Cidade()
        {
            return View();
        }

        public ActionResult Fornecedor()
        {
            return View();
        }

        public ActionResult PerfilUsuario()
        {
            return View();
        }
        public ActionResult Usuario()
        {
            return View();
        }
    }
}

