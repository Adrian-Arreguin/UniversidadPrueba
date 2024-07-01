using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UniversidadExamen.Models;
namespace UniversidadExamen.Presentation
{
    public partial class Form1 : Form
    {
        public int? id;
        tb_Maestro oMaestro = null;
        public Form1(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if(id != null)
            CargaDatos();
        }

        private void CargaDatos()
        {
            using (UniversidadEntities db = new UniversidadEntities())
            {
                oMaestro = db.tb_Maestro.Find(id);
                txtName.Text = oMaestro.nombre;
                txtP.Text = oMaestro.ap_paterno;
                txtM.Text = oMaestro.ap_materno;
                txtMatricula.Text = oMaestro.matricula_empleado;
                dateTimePicker1.Value = oMaestro.fecha_ingreso;
                txtEmail.Text = oMaestro.email;
                txtTel.Text = oMaestro.telefono;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (UniversidadEntities db = new UniversidadEntities())
            {
                if (id == null)
                    oMaestro = new tb_Maestro();

                oMaestro.nombre = txtName.Text;
                oMaestro.ap_paterno = txtP.Text;
                oMaestro.ap_materno = txtM.Text;
                oMaestro.matricula_empleado = txtMatricula.Text;
                oMaestro.fecha_ingreso = dateTimePicker1.Value;
                oMaestro.email = txtEmail.Text;
                oMaestro.telefono = txtTel.Text;

                if(id==null)
                db.tb_Maestro.Add(oMaestro);
                else
                {
                    db.Entry(oMaestro).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();

                this.Close();

            }
        }
    }
}
