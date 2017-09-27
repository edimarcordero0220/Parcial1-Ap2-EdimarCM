using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;
using DAL;

namespace _Parcial1_ap2_EdimarCM_.Consulta
{
    public partial class Consulta_Presupuesto : System.Web.UI.Page
    {
        public static List<Presupuesto> lista { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Presupuesto presupuesto = new Presupuesto();

            //lista = BLL.PresupuestoBLL.GetListaPresupuesto();



        }



        protected void FiltrarButton_Click(object sender, EventArgs e)
        {


        }


        public void SeleccionarItem()
        {
            if (PresupuestoDropDownList.SelectedIndex == 0)
            {
                int id = Convert.ToInt32(FiltrarTextBox.Text);
                //lista = PresupuestoBLL.GetLista(p => p.PresupuestoId == id).ToList();
                PresupuestoGridView.DataSource = lista;
                PresupuestoGridView.DataBind();
            }
        }

        protected void FiltrarButton_Click1(object sender, EventArgs e)
        {

        }

        protected void FiltrarButton_Click2(object sender, EventArgs e)
        {
            if (PresupuestoDropDownList.SelectedIndex == 5)
            {
                if (DesdeTextBox.Text == HastaTextBox.Text)
                {

                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        
            
        }
    
}