using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBuyWinform
{
    public partial class Form1 : Form
    {
        int idAction;
        DateTime date;
        int idCategory;
        string idUsers;
        string img;
        int numPayment;
        int paymentId;
        double sum;
        List<Action> actions = new List<Action>();
        List<BranchDTO> branchDTOs = new List<BranchDTO>();
        List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
        List<PaymentDTO> paymentDTOs = new List<PaymentDTO>();
        public Form1()
        {
            InitializeComponent();
            ControlerService controlerService = new ControlerService();
          actions= controlerService.GetActions();
            categoryDTOs = controlerService.GetCategory();
            paymentDTOs = controlerService.GetPayment();
            ControlerService c = new ControlerService();
          //HttpResponseMessage h= c.find().Result;
          //  List<Action> products = h.Content.ReadAsAsync<List<Action>>().Result;


        }

        private void Form1_Load(object sender, EventArgs e)
        {///
            actionid.DataSource = actions;
            actionid.DisplayMember = "typeAction";
            actionid.ValueMember = "ActionId";
            ///
            payment.DataSource =paymentDTOs ;
            payment.DisplayMember = "paymentDescription";
            payment.ValueMember = "paymentId";
            ///
            category.DataSource = categoryDTOs;
           category.DisplayMember="categoryName";
          category.ValueMember="categoryId" ;
    }

        private void button1_Click(object sender, EventArgs e)
        {
            ProofPurchaseService proofPurchaseService = new ProofPurchaseService();
          proofPurchaseService.GenerateProofPurchase(idAction, date, idCategory, idUsers, img, numPayment, paymentId,sum);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";
            img = fileOpen.FileName;
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fileOpen.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                img = fileOpen.FileName;
            }
            fileOpen.Dispose();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            paymentId = payment.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            idCategory = category.SelectedIndex;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            idUsers = id.Text;
        }

        private void nump_TextChanged(object sender, EventArgs e)
        {
            numPayment = Int32.Parse(nump.Text);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            idAction = actionid.SelectedIndex;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sum = ConvertToDouble(sum1.Text);
        }
        public static double ConvertToDouble(string Value)
        {
            if (Value == null)
            {
                return 0;
            }
            else
            {
                double OutVal;
                double.TryParse(Value, out OutVal);

                if (double.IsNaN(OutVal) || double.IsInfinity(OutVal))
                {
                    return 0;
                }
                return OutVal;
            }
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCategory = category.SelectedIndex;
        }
    }
}
