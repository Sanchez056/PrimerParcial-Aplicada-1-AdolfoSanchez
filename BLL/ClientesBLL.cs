using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using DAL;


namespace BLL
{
   public class ClientesBLL
    {
        public static void Insertar(Clientes c)
        {

            try
            {

                using (var db = new PrimerParcialDb())
                {

                    db.Clientes.Add(c);
                    db.SaveChanges();
                    

                }


            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public static Clientes Buscar(int id)
        {
            var db = new PrimerParcialDb();

            return db.Clientes.Find(id);


        }

        public static void Eliminar(int id)
        {
            var db = new PrimerParcialDb();
           Clientes c = db.Clientes.Find(id);

            db.Clientes.Remove(c);
            db.SaveChanges();
        }

        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new PrimerParcialDb();

            lista = db.Clientes.ToList();

            return lista;


        }

    }
}
