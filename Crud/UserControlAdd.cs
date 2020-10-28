using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class UserControlAdd : UserControl
    {
        public UserControlAdd()
        {
            InitializeComponent();
        }

        //cuando se le da click al boton de crear un nuevo registro
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = MessageBox.Show("¿Quiere crear un nuevo registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (_DialogResult == DialogResult.Yes)
            {
                bunifuGradientPanelNew.Visible = true;
                panelMenu.Visible = false;
            }
        }


        //Preguntando si quiere guardar la informacion
        private void button1_Click(object sender, EventArgs e)
        {
            //Preguntando si agregará esta info.
            DialogResult dialogResult = MessageBox.Show("¿Quiere guardar la siguiente información? \n\n" 

                + "Nombre: " + bunifuMaterialTextboxNombre.Text 
                + "\nApellido: " + bunifuMaterialTextboxApellido.Text
                + "\nTelefono: " + bunifuMaterialTextboxTelefono.Text
                
                + "\n\n¿Es correcta esta información?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);


            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Registro guardado con éxito, la referencia es:\n (0x7092001_missing_reference_ID)" , "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VolverAMenu();
            }
        }


        //cuando se le da click a cancelar la operacion
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult _dialogResult = MessageBox.Show("¿Esta seguro que desea cancelar esta operación?, los cambios no se efectuarán, ni nada de guardará!", "Está cancelando la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if(_dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Operación cancelada", "Ha cancelado la operación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                VolverAMenu();
            }
        }

        public void VolverAMenu()
        {
            bunifuGradientPanelNew.Visible = false;
            panelMenu.Visible = true;
        }
    }
}
