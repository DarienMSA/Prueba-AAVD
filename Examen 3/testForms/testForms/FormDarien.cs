using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cassandra;

namespace testForms
{
    public partial class FormDarien : Form
    {
        public static bool modEmpresa { get; set; }

        public FormDarien()
        {

            InitializeComponent();

        }

        private void btnGen_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textGetCliente.Text) || String.IsNullOrEmpty(cbEmpresa.Text) || dgvProductosCliente.Rows.Count == 1)
            {
                MessageBox.Show("Faltan datos que llenar", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                TimeUuid hora = TimeUuid.NewId();
                string nomCliente;
                string nomEmpresa;
                List<string> objetos = new List<string>();
                List<decimal> costo = new List<decimal>();
                decimal montoFinal = 0;
                LocalDate fechaGenerada = getActualDate();

                nomCliente = textGetCliente.Text;
                nomEmpresa = cbEmpresa.Text;

                for (int rows = 0; rows < dgvProductosCliente.Rows.Count - 1; rows++)
                {
                    for (int col = 0; col < dgvProductosCliente.Rows[rows].Cells.Count; col++)
                    {
                        objetos.Add(dgvProductosCliente.Rows[rows].Cells[col].Value.ToString());
                        col++;
                        costo.Add(Convert.ToDecimal(dgvProductosCliente.Rows[rows].Cells[col].Value.ToString()));

                    }
                }

                montoFinal = Convert.ToDecimal(textMontoTotal.Text);

                var conn = new EnlaceCassandraDarien();
                conn.InsertaDatosDarien(hora, nomCliente, nomEmpresa, objetos, costo, montoFinal, fechaGenerada);

                MessageBox.Show("Se ha generado la nota de compras con éxito", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarDatosPantalla();
            }
            //foreach (var lbl in Controls.OfType<Button>())
            //{
            //    if (lbl.Visible == true)
            //        lbl.Visible = false;
            //}
            //foreach (var lbl in Controls.OfType<ComboBox>())
            //{
            //    if (lbl.Visible == true)
            //        lbl.Visible = false;
            //}
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbProductos.Items.Clear();
            lbPrecios.Items.Clear();
            dgvProductosCliente.Rows.Clear();
            dgvProductosCliente.Refresh();
            textMontoTotal.Text = "0.0";
            string actualItem = cbEmpresa.SelectedItem.ToString();
            fillComboEmpresa(lbProductos, lbPrecios, actualItem);
           
        }

        public LocalDate getActualDate()
        {
            string fecha;
            string yyyy = DateTime.Now.Year.ToString();
            string mm = DateTime.Now.Month.ToString();
            string d = DateTime.Now.Day.ToString();
            fecha = yyyy + "-";
            
            if (Convert.ToInt16(mm) < 10)
                fecha = fecha + "0" + mm + "-";
            else
                fecha = fecha + mm + "-";
            if (Convert.ToInt16(d) < 10)
                fecha = fecha + "0" + d;
            else
                fecha = fecha + d;
            LocalDate actualHora = LocalDate.Parse(fecha);
            return actualHora;
        }

        private void FormDarien_Load(object sender, EventArgs e)
        {
            actualizarDatosPantalla();
        }

        private void actualizarDatosPantalla()
        {


            dgvMostrarProductosPrecios.Rows.Clear();
            dgvMostrarProductosPrecios.Refresh();

            dgvProductosCliente.Rows.Clear();
            dgvProductosCliente.Refresh();

            dgvModifProductosPrecios.Rows.Clear();
            dgvModifProductosPrecios.Refresh();

            lbModifProductos.Items.Clear();
            lbModifPrecios.Items.Clear();

            lbPrecios.Items.Clear();
            lbProductos.Items.Clear();

            dgvMostrar.Rows.Clear();
            dgvMostrar.Refresh();

            cbEmpresa.Text = "";
            cbEmpresa.Items.Clear();
            cbModifCliente.Text = "";
            cbModifCliente.Items.Clear();
            cbModifID.Text = "";
            cbModifID.Items.Clear();
            


            textGetCliente.Text = "";
            textModifCliente.Text = "";

            cbEmpresa.Items.Add("Home Depot");
            cbEmpresa.Items.Add("OfficeMax");
            cbEmpresa.Items.Add("Liverpool");
            
            lbModifEmpresa.Items.Clear();
            lbModifEmpresa.Items.Add("Home Depot");
            lbModifEmpresa.Items.Add("OfficeMax");
            lbModifEmpresa.Items.Add("Liverpool");

            textMontoTotal.Text = "0.0";
            textModifMontoTotal.Text = "0.0";

            var conn = new EnlaceCassandraDarien();
            List<notaCompra> lst1 = new List<notaCompra>();
            lst1 = conn.Get_AllDarien();
            int n = 0;
            foreach (var lst in lst1)
            {
                n = dgvMostrar.Rows.Add();
                cbModifCliente.Items.Add(lst.nomCliente);
                cbModifID.Items.Add(lst.idNota);
                dgvMostrar.Rows[n].Cells[0].Value = lst.idNota;
                dgvMostrar.Rows[n].Cells[1].Value = lst.nomCliente;
                dgvMostrar.Rows[n].Cells[2].Value = lst.nomEmpresa;
                dgvMostrar.Rows[n].Cells[3].Value = lst.montoFinal;
                dgvMostrar.Rows[n].Cells[4].Value = lst.fechaGenerada;
            }
            lbModifEmpresa.Enabled = false;
        }

        private void lbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbProductos.SelectedIndex;
            lbPrecios.SetSelected(index, true);
        }

        private void lbProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            string actualItemProduct = lbProductos.GetItemText(lbProductos.SelectedItem);
            string actualItemCost = lbPrecios.GetItemText(lbPrecios.SelectedItem);
            int n = dgvProductosCliente.Rows.Add();
            dgvProductosCliente.Rows[n].Cells[0].Value = actualItemProduct;
            dgvProductosCliente.Rows[n].Cells[1].Value = actualItemCost;
            decimal acum = Convert.ToDecimal(textMontoTotal.Text);
            acum += Convert.ToDecimal(actualItemCost);
            textMontoTotal.Text = acum.ToString();
        }

        private void dgvMostrar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            dgvMostrarProductosPrecios.Rows.Clear();
            dgvMostrarProductosPrecios.Refresh();

            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.dgvMostrar.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    string id = row.Cells[0].Value.ToString();
                    TimeUuid idNota = TimeUuid.Parse(id);

                    var conn = new EnlaceCassandraDarien();
                    IEnumerable<notaCompra> lst1;
                    lst1 = conn.Get_ProductoPrecioDarien(idNota);
                    int n = 0;

                    foreach (var lst in lst1)
                    {
                        foreach (var lst2 in lst.objetos)
                        {
                            n = dgvMostrarProductosPrecios.Rows.Add();
                            dgvMostrarProductosPrecios.Rows[n].Cells[0].Value = lst.objetos[n];
                            dgvMostrarProductosPrecios.Rows[n].Cells[1].Value = lst.costo[n];
                        }
                    }
                }

            }
        }

        private void cbModifCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbModifEmpresa.Enabled = true;

            dgvModifProductosPrecios.Rows.Clear();
            dgvModifProductosPrecios.Refresh();
            lbModifProductos.Items.Clear();
            lbModifPrecios.Items.Clear();

            int index = cbModifCliente.SelectedIndex;
            cbModifID.SelectedIndex = index;

            string id = cbModifID.Text;
            TimeUuid idNota = TimeUuid.Parse(id);

            var conn = new EnlaceCassandraDarien();
            IEnumerable<notaCompra> lst1;
            lst1 = conn.Get_OneDarien(idNota);
            int n = 0;
            string empresa = "";
            

            foreach (var lst in lst1)
            {
                foreach (var lst2 in lst.objetos)
                {
                    n = dgvModifProductosPrecios.Rows.Add();
                    dgvModifProductosPrecios.Rows[n].Cells[0].Value = lst.objetos[n];
                    dgvModifProductosPrecios.Rows[n].Cells[1].Value = lst.costo[n];
           
                }
                textModifMontoTotal.Text = lst.montoFinal.ToString();
                textFechaGenerada.Text = lst.fechaGenerada.ToString();
                textModifCliente.Text = lst.nomCliente.ToString();
                empresa = lst.nomEmpresa;
            }
            n = 0;
            foreach (string item in lbModifEmpresa.Items)
            {
                if(item.ToString() == empresa)
                {
                    lbModifEmpresa.SelectedIndex = n;
                    break;
                }
                n++;
            }



            lbModifProductos.Items.Clear();
            lbModifPrecios.Items.Clear();


            fillComboEmpresa(lbModifProductos, lbModifPrecios, empresa);
            modEmpresa = true;
        }

        private void fillComboEmpresa(ListBox controlProd, ListBox controlPrecio, string actualItem)
        {
            if (actualItem == "Home Depot")
            {
                controlProd.Items.Add("Rotomartillo");
                controlPrecio.Items.Add("577.00");
                controlProd.Items.Add("Ventilador Techo");
                controlPrecio.Items.Add("4299.99");
                controlProd.Items.Add("Minisplit");
                controlPrecio.Items.Add("7999.00");
                controlProd.Items.Add("Pala Redonda");
                controlPrecio.Items.Add("265.75");
            }
            else if (actualItem == "OfficeMax")
            {
                controlProd.Items.Add("Marcatextos");
                controlPrecio.Items.Add("16.50");
                controlProd.Items.Add("Calc. Científica");
                controlPrecio.Items.Add("499.99");
                controlProd.Items.Add("Grapa estándar");
                controlPrecio.Items.Add("38.50");
                controlProd.Items.Add("Triturador de hojas");
                controlPrecio.Items.Add("1999.20");
            }
            else if (actualItem == "Liverpool")
            {
                controlProd.Items.Add("Pantalla 4k 55p");
                controlPrecio.Items.Add("1198.56");
                controlProd.Items.Add("Barra de Sonido");
                controlPrecio.Items.Add("4549.35");
                controlProd.Items.Add("Mueble para TV");
                controlPrecio.Items.Add("7779.00");
            }
        }

        private void lbModifProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbModifProductos.SelectedIndex;
            lbModifPrecios.SetSelected(index, true);
        }

        private void lbModifProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string actualItemProduct = lbModifProductos.GetItemText(lbModifProductos.SelectedItem);
            string actualItemCost = lbModifPrecios.GetItemText(lbModifPrecios.SelectedItem);
            int n = dgvModifProductosPrecios.Rows.Add();
            dgvModifProductosPrecios.Rows[n].Cells[0].Value = actualItemProduct;
            dgvModifProductosPrecios.Rows[n].Cells[1].Value = actualItemCost;
            decimal acum = Convert.ToDecimal(textModifMontoTotal.Text);
            acum += Convert.ToDecimal(actualItemCost);
            textModifMontoTotal.Text = acum.ToString();
        }

        private void lbModifEmpresa_MouseClick(object sender, MouseEventArgs e)
        {
            dgvModifProductosPrecios.Rows.Clear();
            dgvModifProductosPrecios.Refresh();
            lbModifProductos.Items.Clear();
            lbModifPrecios.Items.Clear();
            fillComboEmpresa(lbModifProductos, lbModifPrecios, lbModifEmpresa.Text);
            textModifMontoTotal.Text = "0.0";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textModifCliente.Text) || String.IsNullOrEmpty(lbModifEmpresa.Text) || dgvModifProductosPrecios.Rows.Count == 1)
            {
                MessageBox.Show("Faltan datos que llenar", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nomCliente;
                string nomEmpresa;
                List<string> objetos = new List<string>();
                List<decimal> costo = new List<decimal>();
                decimal montoFinal = 0;
                LocalDate fechaGenerada = getActualDate();
                TimeUuid id = TimeUuid.Parse(cbModifID.Text);

                nomCliente = textModifCliente.Text;
                nomEmpresa = lbModifEmpresa.Text;

                for (int rows = 0; rows < dgvModifProductosPrecios.Rows.Count - 1; rows++)
                {
                    for (int col = 0; col < dgvModifProductosPrecios.Rows[rows].Cells.Count; col++)
                    {
                        objetos.Add(dgvModifProductosPrecios.Rows[rows].Cells[col].Value.ToString());
                        col++;
                        costo.Add(Convert.ToDecimal(dgvModifProductosPrecios.Rows[rows].Cells[col].Value.ToString()));

                    }
                }

                montoFinal = Convert.ToDecimal(textModifMontoTotal.Text);

                var conn = new EnlaceCassandraDarien();
                conn.ActualizarDatosDarien(id, nomCliente, nomEmpresa, objetos, costo, montoFinal, fechaGenerada);
                MessageBox.Show("Se han modificado con éxito los datos!", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarDatosPantalla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbModifCliente.Text))
            {
                MessageBox.Show("No se ha seleccionado Cliente", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialog = new DialogResult();

                dialog = MessageBox.Show("¿Seguro que desea eliminar?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {


                    TimeUuid id = TimeUuid.Parse(cbModifID.Text);
                    var conn = new EnlaceCassandraDarien();
                    conn.EliminarClienteDarien(id);
                    MessageBox.Show("Se ha eliminado con éxito!", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarDatosPantalla();
                }
            }
        }

        private void dgvModifProductosPrecios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("¿Seguro que desea eliminar?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {

                if (e.RowIndex > -1)
                {
                    DataGridViewRow row = this.dgvModifProductosPrecios.Rows[e.RowIndex];
                    if (row.Cells[0].Value != null)
                    {
                        decimal precio = Convert.ToDecimal(row.Cells[1].Value.ToString());
                        decimal montoFinal = Convert.ToDecimal(textModifMontoTotal.Text);
                        montoFinal -= precio;
                        TimeUuid idNota = TimeUuid.Parse(cbModifID.Text);

                        var conn = new EnlaceCassandraDarien();
                        conn.EliminaProdPrecDarien(idNota, e.RowIndex, montoFinal);
                        dgvModifProductosPrecios.Rows.RemoveAt(e.RowIndex);
                        textModifMontoTotal.Text = montoFinal.ToString();
                        //actualizarDatosPantalla();
                    }

                }
            }
        }

        ////////////////////////////////////////////////////////////////// eventos inutilizados

        private void dgvModifProductosPrecios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cbModifEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTraer_Click(object sender, EventArgs e)
        {


        }

        private void lbPrecios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
