using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PresupuestoBLL
    {
        public static void Insertar(Presupuesto p)
        {
            try
            {
               Parcial1Db db = new Parcial1Db();
                db.presupuesto.Add(p);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Eliminar(Presupuesto p)
        {
            Parcial1Db db = new Parcial1Db();
            Presupuesto pre = db.presupuesto.Find(p);

            db.presupuesto.Remove(pre);
            db.SaveChanges();
        }
        public static bool Modificar(int id, Presupuesto us)
        {
            bool retorno = false;
            try
            {
                using (var db = new Parcial1Db())
                {
                    Presupuesto usa = db.presupuesto.Find(id);
                    usa.PresupuestoId = us.PresupuestoId;
                    usa.Monto = us.Monto;
                    usa.Fecha = us.Fecha;
                    usa.Descripcion = us.Descripcion;
                    db.SaveChanges();
                }
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }
        public static List<Presupuesto> GetListaPresupuesto(int tmp)
        {
            List<Presupuesto> lista = new List<Presupuesto>();
            Parcial1Db db = new Parcial1Db();
            lista = db.presupuesto.Where(p => p.PresupuestoId == tmp).ToList();
            return lista;
        }
        public static List<Presupuesto> GetListaPresupuesto(DateTime tmp)
        {
            List<Presupuesto> lista = new List<Presupuesto>();
            Parcial1Db db = new Parcial1Db();
            lista = db.presupuesto.Where(p => p.Fecha == tmp).ToList();
            return lista;
        }
    }
}
