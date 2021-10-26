using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _NCrypt_
{
    public partial class Form1 : Form
    {
        //Iniciacion
        byte[] abc;
        byte[,] tabla;

        public Form1()
        {
            InitializeComponent();
        }

        #region Botones
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                txtUbicacion.Text = od.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEncriptar.Checked)
            {
                rbDesencriptar.Checked = false;
            }
        }

        private void rbDesencriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDesencriptar.Checked)
            {
                rbEncriptar.Checked = false;
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            rbEncriptar.Checked = true;
            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            tabla = new byte[256,256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                {
                    tabla[i, j] = abc[(i + j) % 256];
                }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Verificacion de datos
            if (!File.Exists(txtUbicacion.Text))
            {
                MessageBox.Show("No has insertado un archivo.");
                return;
            }
            if (String.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Por favor ingresar su contraseña.");
                return;
            }
            //
            try
            {
                byte[] Ubicacion = File.ReadAllBytes(txtUbicacion.Text);
                byte[] Contraseña = Encoding.ASCII.GetBytes(txtContraseña.Text);
                byte[] keys = new byte[Ubicacion.Length];
                for (int i = 0; i < Ubicacion.Length; i++)
                    keys[i] = Contraseña[i%Contraseña.Length];

                //Encriptacion
                byte[] Encriptar = new byte[Ubicacion.Length];
                if (rbEncriptar.Checked)
                {

                    for (int i = 0; i < Ubicacion.Length; i++)
                    {
                        byte value = Ubicacion[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        Encriptar[i] = tabla[keyIndex, valueIndex];
                    }

                }

                //Desencriptacion
                else
                {
                    for (int i = 0; i < Ubicacion.Length; i++)
                    {
                        byte value = Ubicacion[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (tabla[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        Encriptar[i] = abc[valueIndex];
                    }
                }

                //Guardar archivo con la misma extension
                String Extension = Path.GetExtension(txtUbicacion.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files (*" + Extension + ") | *"  + Extension;
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, Encriptar);
                }
            }
            catch
            {
                MessageBox.Show("Este archivo esta en uso en otro programa, favor cerrar el programa e intentarlo otra vez");
                return;
            }
        }
    }
}