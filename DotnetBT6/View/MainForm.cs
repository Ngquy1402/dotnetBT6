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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            QLSVDataContext db = new QLSVDataContext();
            ShowcbbNameLop.Items.Add(new CBBItem { Value = 0, Text = "ALL"});
            foreach (LSH i in db.LSHes)
            {
                ShowcbbNameLop.Items.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.Name_Lop
                });
            }
        }
        public void LoadDGV()
        {
            using(QLSVDataContext db = new QLSVDataContext())
            {
                dataGridView1.DataSource = db.SVs.OrderBy(p => p.LSH.ID_Lop)
                .Select(p => new { p.MSSV, p.LSH.Name_Lop, p.NameSV, p.GioiTinh, p.DTB });
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        public void Loadsenddata(string maSV, int lopSH, string nameSV,
                                           string dTB, string genDer)
        {
            double check;
            Double.TryParse(dTB, out check);
            SV s = new SV()
            {
                MSSV = maSV,
                ID_Lop = lopSH,
                NameSV = nameSV,
                DTB = check,
                GioiTinh = genDer
            };
            QLSVDataContext db = new QLSVDataContext();
            db.SVs.InsertOnSubmit(s);
            db.SubmitChanges();
            LoadDGV();
        }
        private void butShow_Click(object sender, EventArgs e)
        {
            using (QLSVDataContext db = new QLSVDataContext()) 
            {
                if (((CBBItem)ShowcbbNameLop.SelectedItem).Value == 0)
                {
                    dataGridView1.DataSource = db.SVs.OrderBy(p => p.ID_Lop)
                        .Select(p => new { p.MSSV, p.LSH.Name_Lop, p.NameSV, p.GioiTinh, p.DTB });
                    //.ToList();
                }
                else
                {
                    dataGridView1.DataSource = db.SVs.OrderBy(p => p.ID_Lop)
                        .Where(p => p.ID_Lop == ((CBBItem)ShowcbbNameLop.SelectedItem).Value)
                        .Select(p => new { p.MSSV, p.LSH.Name_Lop, p.NameSV, p.GioiTinh, p.DTB });
                    //.ToList();
                }
            }
                
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.senddata = new AddForm.TruyenData(Loadsenddata);
            addForm.ShowDialog();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban muon thay doi thong tin tren?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                QLSVDataContext db = new QLSVDataContext();
                var st = (from s in db.SVs where s.MSSV == Convert.ToString(txtMSSV.Text) select s).First();
                st.LSH.Name_Lop = cbbNameLop.Text;
                st.NameSV = txtNameSV.Text;
                st.DTB = Convert.ToDouble(txtDTB.Text);
                if(Namradiobut.Checked == true)
                {
                    st.GioiTinh = Namradiobut.Text;
                }
                else
                {
                    st.GioiTinh = Nuradiobut.Text;
                }
                //st.GioiTinh = Namradiobut.Checked ? true : false;
                db.SubmitChanges();
                MessageBox.Show("Thay doi thong tin thanh cong!");
                LoadDGV();
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon xoa du lieu nay?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Xoa du lieu thanh cong!");
                QLSVDataContext db = new QLSVDataContext();
                string masv = dataGridView1.SelectedCells[0].OwningRow.Cells["MSSV"].Value.ToString();
                SV del = db.SVs.Where(p => p.MSSV == masv).SingleOrDefault();
                db.SVs.DeleteOnSubmit(del);
                db.SubmitChanges();
                LoadDGV();
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            using (QLSVDataContext db = new QLSVDataContext())
            {
                var l1 = db.SVs.Where(P => P.NameSV.Contains(txtSearch.Text))
                    .Select(p => new { p.MSSV, p.LSH.Name_Lop, p.NameSV, p.GioiTinh, p.DTB });
                //.ToList();
                dataGridView1.DataSource = l1;
                //if (((CBBItem)ShowcbbNameLop.SelectedItem).Value == 0)
                //{
                //    dataGridView1.DataSource = db.SVs
                //        .Where(P => P.NameSV.Contains(txtSearch.Text))
                //        .Select(p => new { p.MSSV, p.LSH.Name_Lop, p.NameSV, p.GioiTinh, p.DTB });
                //         //.ToList();
                //}
                //else
                //{
                //    dataGridView1.DataSource = db.SVs
                //        .Where(p => p.ID_Lop == ((CBBItem)ShowcbbNameLop.SelectedItem).Value
                //        && p.NameSV.Contains(txtSearch.Text))
                //        .Select(p => new { p.MSSV, p.LSH.Name_Lop, p.NameSV, p.GioiTinh, p.DTB });
                //        //.ToList();
                //}
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            QLSVDataContext db = new QLSVDataContext();
            string masv = dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString();
            foreach (SV i in db.SVs)
            {
                if (i.MSSV == masv)
                {
                    txtMSSV.Text = i.MSSV;
                    cbbNameLop.Text = i.LSH.Name_Lop;
                    txtNameSV.Text = i.NameSV;
                    txtDTB.Text = Convert.ToString(i.DTB);
                    if (i.GioiTinh == "Nam")
                    {
                        Namradiobut.Checked = true;
                    }

                    else
                    {
                        Nuradiobut.Checked = true;
                    }

                }
            }
        }
    }
}
//test git nha may tml kho dung vkl ay