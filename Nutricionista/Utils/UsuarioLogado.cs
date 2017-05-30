using Nutricionista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nutricionista.Utils
{
    public static class UsuarioLogado
    {
        public static bool IsLogado
        {
            get
            {
                return Usuario != null;
            }
        }

        public static Usuario Usuario
        {
            get
            {
                return HttpContext.Current.Session["Usuario"] as Usuario;
            }
            set
            {
                HttpContext.Current.Session["Usuario"] = value;
            }
        }
    }
}