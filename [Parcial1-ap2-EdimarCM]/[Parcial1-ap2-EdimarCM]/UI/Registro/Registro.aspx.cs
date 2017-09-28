using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;

namespace _Parcial1_ap2_EdimarCM_.UI.Registro
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox1.Text = string.Format("{0:G}", DateTime.Now);


            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
        }

        private Presupuesto Llenar()
        {
            Presupuesto p = new Presupuesto();
            p.Fecha = Convert.ToDateTime(FechaTextBox1.Text);
            p.Descripcion = DescripcionTextBox1.Text;
            //p.Monto = Convert.ToInt32(MontoTextBox1.Text);
            return p;
        }

        protected void GuardaButton_Click(object sender, EventArgs e)
        {
            Presupuesto presupu = new Presupuesto();
            if (IsValid)
            {
                if (presupu.PresupuestoId != 0)
                {
                    PresupuestoBLL.Mofidicar(presupu);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('El Usuario se ha Modificado');</script>");
                }
                else
                {
                    presupu = Llenar();
                    PresupuestoBLL.Guardar(presupu);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Presupuesto Guardado');</script>");

                }
            }

        }
        
        public void BuscarPresupuesto(Presupuesto presupuesto)
        {
            
                IdTextBox.Text = presupuesto.PresupuestoId.ToString();
                DescripcionTextBox1.Text = presupuesto.Descripcion;
                FechaTextBox1.Text = Convert.ToString(presupuesto.Fecha);
                MontoTextBox1.Text = Convert.ToString(presupuesto.Monto);
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(IdTextBox.Text);
            Presupuesto presupu = PresupuestoBLL.Buscar(p => p.PresupuestoId == id);
            if (presupu != null)
            {
                FechaTextBox1.Text = presupu.Fecha.ToString();
                DescripcionTextBox1.Text = presupu.Descripcion;
                MontoTextBox1.Text = presupu.Monto.ToString();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No existe el Usuario');</script>");
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(IdTextBox.Text);
            Presupuesto presupu = PresupuestoBLL.Buscar(p => p.PresupuestoId == id);
            if (presupu != null)
            {
                if (presupu.PresupuestoId != 1)
                {
                    PresupuestoBLL.Eliminar(presupu);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Presupuesto Eliminado');</script>");
                    
                }
            }
        }

    }
    }

