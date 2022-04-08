using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

using PetshopApp.Models;

namespace PetshopApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int vezes=1)
        {
            ViewData["Mensagem"] = "Olá " + name;
            ViewData["Vezes"] = vezes;

            return View();
        }

        public string Testes(string name, int ID = 1)
        {
            List<TesteModel> banco = new List<TesteModel>();
            for(int i = 1; i < 10; i ++) {
                banco.Add(new TesteModel{ID=i, Nome=$"Baozi{i}"});
            }

            for(int i = 0; i < banco.Count; i++){
                if(banco[i].ID == ID){
                    return HtmlEncoder.Default.Encode($"ID: {ID}, Nome: {banco[i].Nome}");
                }
            }
            return "Não foi encontrado registro no banco";
        }
    }
}