using DotnetBT6.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotnetBT6.View
{
    public partial class AddForm : Form
    {
        public delegate void TruyenData(string maSV, int lopSH, string nameSV,
                                           string dTB, string genDer);
        public TruyenData senddata;
        public AddForm()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            QLSVDataContext db = new QLSVDataContext();
            foreach (LSH i in db.LSHes)
            {
                cbbLSHAdd.Items.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.Name_Lop
                });

            }
        }

        private void OKButAdd_Click(object sender, EventArgs e)
        {
            string maSV = txtMSSVAdd.Text;
            int lopSH = ((CBBItem)cbbLSHAdd.SelectedItem).Value;
            string nameSV = txtNamesvAdd.Text;
            string dTB = txtDtbAdd.Text;
            string genDer;
            if (AddNamradiobut.Checked == true)
            {
                genDer = AddNamradiobut.Text;
            }
            else
            {
                genDer = AddNuradiobut.Text;
            }
            //bool genDer = radioButton1.Checked ? true : false;
            senddata(maSV, lopSH, nameSV, dTB, genDer);
            this.Dispose();
        }

        private void CancelButAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
