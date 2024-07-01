using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UniversidadExamen.Models;

namespace UniversidadExamen
{
    public partial class MaestroForm : Form
    {
        public MaestroForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MenuForm nuevoForm = new MenuForm();
            nuevoForm.Show();
            this.Hide();
        }

        private void MaestroForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            using (UniversidadEntities db = new UniversidadEntities())
            {
                var lst = from d in db.tb_Maestro
                          select d;

                dataGridView1.DataSource = lst.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Presentation.Form1 oFrmTabla = new Presentation.Form1();
            oFrmTabla.ShowDialog();

            Refresh();
        }
        private int? GetId()
        {
            try {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()); 
            } catch {
                return null; 
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Presentation.Form1 ofrmTabla = new Presentation.Form1(id);
                ofrmTabla.ShowDialog();

                Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (UniversidadEntities db = new UniversidadEntities())
                {
                    tb_Maestro oMaestro = null;
                    oMaestro = db.tb_Maestro.Find(id);
                    db.tb_Maestro.Remove(oMaestro);
                    db.SaveChanges();
                }
                    Refresh();
            }
        }
    }
}
