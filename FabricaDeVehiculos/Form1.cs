using Entidades;
namespace FabricaDeVehiculos
{
    public partial class Form1 : Form
    {
        private Fabrica fabrica;
        public Form1()
        {
            InitializeComponent();
            this.InicializarFabrica();
            lstVehiculos.Refresh();
        }

        private void InicializarFabrica()
        {
            this.fabrica = new Fabrica(150);
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Automovil");
            cmbTipo.Items.Add("Moto");
            cmbTipo.Items.Add("Camioneta");
        }
    }
}