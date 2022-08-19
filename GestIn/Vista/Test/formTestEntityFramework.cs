using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.Vista.Test
{
    public partial class formTestEntityFramework : Form
    {
        public formTestEntityFramework()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            Usuario usuario = new Usuario() { 
                Dni = 85452014,
                Email="FRAMEWORK@GMAIL.COM",
                Password="123456789",
                Rol="Alumno",
                Nombre="Entity",
                Apellido="Framework",
                FechaDeNacimiento=new DateTime(2022,08,18),
                LugarDeNacimiento="Miramar",
                Celular="7410852",
                CelularDeEmergencia="978456",
                Sexo="Masculino"
            };
            using (var context = new Context())
            {
                context.Add(usuario);
                context.SaveChanges();
            }
            */
        }
    }
}
