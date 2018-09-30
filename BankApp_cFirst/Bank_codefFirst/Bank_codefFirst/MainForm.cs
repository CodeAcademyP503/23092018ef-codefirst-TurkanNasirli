using Bank_codefFirst.Forms;
using Bank_codefFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_codefFirst
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_person_Click(object sender, EventArgs e)
        {
            Person person = null;
            using (DatabaseContext Data = new DatabaseContext())
            {
                try
                {
                    person= Data.People.Add(new Person()
                    {
                        Name = txt_name.Text,
                        Surname = txt_sname.Text,
                        CardNumber = txt_cnum.Text
                    });
                }
                catch (DbEntityValidationException exp)
                {
                    throw exp;
                }
            }
            CreditForm creditForm = new CreditForm(person);
            creditForm.ShowDialog();
        }
    }


}
