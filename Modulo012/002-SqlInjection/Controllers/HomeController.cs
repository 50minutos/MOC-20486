using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using _002_SqlInjection.Models;

namespace _002_SqlInjection.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(String id)
        {
            var estados = new List<Estado>();
            var cs = "Data Source=kilowog;Initial Catalog=db;Integrated Security=true;";
            var cmd = "select * from Estado where EstadoId like'%" + id + "%'";

            //http://localhost:62604/Home/Index?ID=SP%' UNION SELECT TABLE_SCHEMA, TABLE_NAME FROM INFORMATION_SCHEMA.TABLES--
            //http://localhost:62604/Home/Index?ID=SP%' UNION SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS--
            //http://localhost:62604/Home/Index?ID=SP%' UNION SELECT LOGINNOME, LOGINSENHA FROM LOGIN--
            //http://localhost:62604/Home/Index?ID=SP%'; UPDATE LOGIN SET LOGINSENHA = 'ABC123@'--

            using (var c = new SqlConnection(cs))
            {
                using (var k = new SqlCommand(cmd, c))
                {
                    c.Open();

                    var dr = k.ExecuteReader();

                    while (dr.Read())
                    {
                        estados.Add(new Estado { EstadoSigla = dr[0].ToString(), EstadoNome = dr[1].ToString() });
                    }

                    c.Close();
                }
            }

            return View(estados);
        }

        public ActionResult Index2(String id)
        {
            var estados = new List<Estado>();
            var cs = "Data Source=kilowog;Initial Catalog=db;Integrated Security=true;";
            var cmd = "select * from Estado where EstadoId like @EstadoId";

            //http://localhost:62604/Home/Index2?ID=SP%' UNION SELECT TABLE_SCHEMA, TABLE_NAME FROM INFORMATION_SCHEMA.TABLES--
         
            using (var c = new SqlConnection(cs))
            {
                using (var k = new SqlCommand(cmd, c))
                {
                    k.Parameters.AddWithValue("@EstadoId", id);

                    c.Open();

                    var dr = k.ExecuteReader();

                    while (dr.Read())
                    {
                        estados.Add(new Estado { EstadoSigla = dr[0].ToString(), EstadoNome = dr[1].ToString() });
                    }

                    c.Close();
                }
            }

            return View(estados);
        }
    }
}