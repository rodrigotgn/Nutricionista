using Nutricionista.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Nutricionista.Controllers
{
    public class UtilsController : ApiController
    {
        private MainContext db = new MainContext();

        // GET: api/Utils
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Utils/5
        public ActionResult Get(int id) 
        {
            var obj = db.DepoimentoItems.Where(p => p.NumChave == id).First();


            //return new FileContentResult(obj.DesImagem, "image/jpeg");
            return null;
        }

        // POST: api/Utils
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Utils/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Utils/5
        public void Delete(int id)
        {
        }

        public string UploadFile(HttpPostedFileBase file, string TipoTabela, string CodTabela)
        {
            try
            {
                if (file == null)
                {
                    throw new Exception("Não foi possível receber a imagem.");
                }

                BinaryReader rdr = new BinaryReader(file.InputStream);
                byte[] fileData = rdr.ReadBytes(file.ContentLength);
                rdr.Close();

                string filename = DateTime.Now.ToString("yyyymmddhhmmss");

                //Adicionar o "fileData" na base 

                //Retorna o caminho da imagem.
                return string.Concat("Cadastro/Imagens/", filename);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [System.Web.Http.HttpGet]
        public ActionResult RetornaImagem(string CodImagem)
        {
            // Faz um select no banco
            //var obj. = objTabela;

            //obj.Data deve ser um byte []

            //if (obj.Data != null)
            //{
            //    return File(obj.Data, "image/png");
            //}
            //else
            //{
                return null;
            //}
        }


        //public JsonResult GetImagens(int TipoTabela, int CodTabela)
        //{
        //    var lista = RetornaImagens(TipoTabela, CodTabela);

        //    return Json(lista);
        //}
    }
}
