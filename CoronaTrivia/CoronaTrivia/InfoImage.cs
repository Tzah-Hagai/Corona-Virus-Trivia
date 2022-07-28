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
using System.Collections;

namespace CoronaTrivia
{
    public partial class InfoImage : Form //Creates a new Info text with a picture and adds it to the infoData txt file.
    {
        OpenFileDialog imgAdd = new OpenFileDialog();
        public InfoImage()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dLines = File.ReadAllLines("DATA/infoData.txt"); //Reads the lines of the txt file and puts them in array.
                Data newInfo = new Data();
                newInfo.DataNumber = dLines.Length + 1;
                newInfo.DataTopic = txtHead.Text;
                newInfo.DataContent = txtBody.Text;
                string picAdr = imgAdd.FileName; //Gets the image file adress.
                string picName = Path.GetFileName(picAdr); //Gets the image file name.
                newInfo.DataImage = picName;
                if (txtHead.Text != "" && txtBody.Text != "" && pcbAdd.Image != null)
                {
                    string insertData = "\n" + newInfo.DataNumber + ";" + newInfo.DataTopic 
                        + ";" + newInfo.DataContent + ";" + newInfo.DataImage;
                    StreamWriter sw = new StreamWriter("DATA/infoData.txt", true);   //Creates and saves the new info in the txt file.
                    sw.Write(insertData);
                    sw.Close();
                    File.Copy(picAdr, "DIMAGES/" + picName); //Copys the image file and puts it in the folder.
                    new Menu().Show();
                    this.Close();
                }
                else if (txtHead.Text == "")
                {
                    MessageBox.Show("Please add an headline!");
                }
                else if (txtBody.Text == "")
                {
                    MessageBox.Show("Please add some content!");
                }
                else if (pcbAdd.Image == null)
                {
                    MessageBox.Show("Please add an image!");
                }
            }
            catch (FileNotFoundException e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch (FileLoadException e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch (IOException e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            imgAdd.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"; 

            if (imgAdd.ShowDialog() == DialogResult.OK)                //Puts the image in the Pic box.
            {
                pcbAdd.Image = Image.FromFile(imgAdd.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AddInfo().Show();
            this.Close();
        }
    }
}
