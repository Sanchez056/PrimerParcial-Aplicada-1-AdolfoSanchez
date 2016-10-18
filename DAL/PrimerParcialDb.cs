using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;


namespace DAL
{
    public class PrimerParcialDb : DbContext
    {
        public PrimerParcialDb() : base("name=ConStr")
        {

        }

        public virtual DbSet<Clientes> Clientes { get; set; }

}

    
}
