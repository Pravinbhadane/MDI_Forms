using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace MDI_Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"E:\TQ\Wforms";

                if (Directory.Exists(path))
                {
                    MessageBox.Show("File is already exist");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("File is created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex .Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"E:\TQ\Wforms\file.txt";

                if (File.Exists(path))
                {
                    MessageBox.Show("File is already exist");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File is created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void txtWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
               string path = @"E:\TQ\Wforms\produt.dat";

                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                binaryWriter.Write(Convert.ToInt32(txtId.Text));
                binaryWriter.Write(txtName.Text);
                binaryWriter.Write(Convert.ToDouble(txtPrice.Text));
                binaryWriter.Close();
                fileStream.Close();
                MessageBox.Show("Done");
                txtId.Clear();
                txtName.Clear();
                txtPrice.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"E:\TQ\Wforms\produt.dat";

                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                txtId.Text = binaryReader.ReadInt32().ToString();
                txtName.Text =binaryReader.ReadString();
                txtPrice.Text =binaryReader.ReadDouble().ToString();
                binaryReader.Close();
                fileStream.Close();
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
