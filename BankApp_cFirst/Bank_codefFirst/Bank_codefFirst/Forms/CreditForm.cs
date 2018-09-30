using Bank_codefFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Windows.Forms;

namespace Bank_codefFirst.Forms
{
    public partial class CreditForm : Form
    {
        private readonly Person Person;
        public CreditForm()
        {
            InitializeComponent();
           
        }

        public CreditForm( object person):this()
        {
            Person = person as Person;
        }

        private void btn_person_Click(object sender, EventArgs e)
        {
            
            using (DatabaseContext Data = new DatabaseContext())
            {
                try
                {
                   Data.Credits.Add(new Credit()
                    {
                        Person=Person,
                        Amount = Convert.ToDecimal(txt_amount.Text),
                        Disburs = Date_Credit.Value.Date
                    });
                    Data.SaveChanges();
                }
                catch (DbEntityValidationException exp)
                {

                    throw exp;
                }

               
            }
        }

        private void CreditForm_Load(object sender, EventArgs e)
        {
            txt_pname.Text = Person.Name;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            AllData allData = new AllData();

            using(DatabaseContext db =new DatabaseContext())
            {
                for (int i=0;i< db.People.ToList().Count;i++)
                {
                    allData.dataGridView1.Rows.Add();
                    allData.dataGridView1.Rows[i].Cells[0].Value = db.People.ToList()[i].ID;
                    allData.dataGridView1.Rows[i].Cells[1].Value = db.People.ToList()[i].Name;
                    allData.dataGridView1.Rows[i].Cells[2].Value = db.Credits.ToList()[i].Amount;
                }
            }
            
          
            allData.ShowDialog();
        }
    }
}
