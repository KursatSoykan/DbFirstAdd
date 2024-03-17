using DbFirstAdd.Models;
using DbFirstAdd.Services;

namespace DbFirstAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SupplierService supplierService = new SupplierService();
            dtwSuplier.DataSource = supplierService.GetSuppliers();
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            NorthwndContext context = new NorthwndContext();
            SupplierService supplierService = new SupplierService();
            int id = Convert.ToInt32(dtwSuplier.CurrentRow.Cells[0].Value);
            supplierService.DeleteSupplier(id);
            dtwSuplier.DataSource = supplierService.GetSuppliers();



        }

        private void dtwSuplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dtwSuplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
