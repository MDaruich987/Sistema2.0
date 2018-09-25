using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeAbogados
{
    public partial class FormInicioSecretario : Form
    {
        public FormInicioSecretario()
        {
            InitializeComponent();
            this.Opacity = 0.98;
            InsertarFilasVencimientoProveidos();
            InsertarFilasUltimosComentarios();
        }

        private void InsertarFilasVencimientoProveidos()
        {
            gridvencimientosproveidos.Rows.Insert(0,1, "2 días", "20/09/2018", 1562, "Carlos Lopez", "Carnet de conducir");
            gridvencimientosproveidos.Rows.Insert(1,23, "4 días", "22/09/2018",127, "Maria Polo", "Prueba de ADN");
            gridvencimientosproveidos.Rows.Insert(2,2, "7 días", "25/09/2018", 127, "Maria Polo", "Estudio de Sangre");


        }

        private void InsertarFilasUltimosComentarios()
        {
            gridcomentariosprocuraciones.Rows.Insert(0, 1562, "17/09/2018", "Carlos Lopez", "Arreglar citación con el acusado para discutir...");
            gridcomentariosprocuraciones.Rows.Insert(1, 23, "17/09/2018", "Carlos Lopez", "Retirar la documentación presentada en la dependencia");
            gridcomentariosprocuraciones.Rows.Insert(2, 127, "16/09/2018", "Maria Polo", "Firmar papeles de contrato con el cliente para..");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gridvencimientosproveidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
