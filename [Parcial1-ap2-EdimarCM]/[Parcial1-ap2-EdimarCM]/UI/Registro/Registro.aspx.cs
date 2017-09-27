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
        public void LlenarClase(Presupuesto p)
        {
            p.Descripcion = DescripcionTextBox1.Text;
            p.Fecha = Convert.ToDateTime(FechaTextBox1.Text);
            p.Monto = Convert.ToInt32(MontoTextBox1.Text);
        }

        protected void GuardaButton_Click(object sender, EventArgs e)
        {
            Presupuesto presupuesto = new Presupuesto();
            LlenarClase(presupuesto);
            PresupuestoBLL.Insertar(presupuesto);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Guardado !');</script> ");
          
            FechaTextBox1.Focus();

        }
    }
}