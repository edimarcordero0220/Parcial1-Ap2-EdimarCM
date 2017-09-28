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
            PresupuestoGridView.DataSource = PresupuestoBLL.GetListTodo();
            PresupuestoGridView.DataBind();


        }
        private bool ValidarConsulta()
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
            if (string.IsNullOrEmpty(FiltrarTextBox.Text))
            {

                return true;
            }



            return true;
        }


        protected void FiltrarButton_Click(object sender, EventArgs e)
        {


        }




        protected void FiltrarButton_Click1(object sender, EventArgs e)
        {

        }

        protected void FiltrarButton_Click2(object sender, EventArgs e)
        {


        }

        protected void PresupuestoGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void FiltrarButton_Click3(object sender, EventArgs e)
        {
            BuscarSelecCombo();

        }
        private void BuscarSelecCombo()
        {
            if (PresupuestoDropDownList.SelectedIndex == 0)
            {
                int Busqueda = Utilidades.TOINT(FiltrarTextBox.Text);
                lista = PresupuestoBLL.GetList(p => p.PresupuestoId == Busqueda);
                PresupuestoGridView.DataSource = lista;
                PresupuestoGridView.DataBind();
            }
            else if (PresupuestoDropDownList.SelectedIndex == 1)
            {
                DateTime desde = Convert.ToDateTime(DesdeTextBox.Text);
                DateTime hasta = Convert.ToDateTime(HastaTextBox.Text);

                if (DesdeTextBox.Text != "" && HastaTextBox.Text != "")
                {
                    if (desde <= hasta)
                    {
                        lista = PresupuestoBLL.GetList(p => p.Fecha >= desde && p.Fecha <= hasta);
                        PresupuestoGridView.DataSource = lista;
                        PresupuestoGridView.DataBind();
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('inserta la fecha');</script>");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Insertar el Intervalo de Fecha');</script>");
                }
            }
        }

    }
}