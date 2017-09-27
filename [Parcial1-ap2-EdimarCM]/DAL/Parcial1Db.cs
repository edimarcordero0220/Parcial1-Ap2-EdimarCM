using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

namespace DAL
{
    public class Parcial1Db : DbContext
    {

        public Parcial1Db() : base("name=ConStr")
        {
                
        }
        public virtual DbSet<Presupuesto> presupuesto { get; set; }


    }
}
