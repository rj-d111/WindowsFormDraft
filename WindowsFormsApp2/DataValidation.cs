using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DataValidation : Form
    {
        public DataValidation()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            customerBindingSource.AddNew();
            //customerBindingSource.DataSource = new Customer();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            customerBindingSource.EndEdit();
            Customer customer = customerBindingSource.Current as Customer;
            if(customer != null )
            {
                if (customer.IsValid)
                {

                }
            }
            //ValidationContext context = new ValidationContext(customer, null, null);
            //IList<ValidationResult> errors = new List<ValidationResult>();
            //if (!Validator.TryValidateObject(customer, context, errors, true))
            //{
            //    foreach(ValidationResult result in errors)
            //    {
            //        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}
        }

        private void DataValidation_Load(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = new List<Customer>();
        }
    }
}
