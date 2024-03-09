namespace registro_personas_gui_01_5_2_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btn_Nuevo.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Eliminar.Enabled = false;

            txt_Nombre.Enabled = true;
            txt_Edad.Enabled = true;
            txt_Nombre.Focus();

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Editar.Enabled = true;
            btn_Eliminar.Enabled = true;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btn_Nuevo.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Eliminar.Enabled = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Eliminar.Enabled = false;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Nombre.Enabled=false;
            txt_Edad.Enabled=false;
        }
    }
}