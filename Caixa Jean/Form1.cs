using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Jean
{
    public partial class Form1 : Form
    {
       
       //////////////////////////////////////////      
        const int numeroDeProdutos = 8;        //
       //////////////////////////////////////////
      
        int[] Id = new int[numeroDeProdutos];
        string[] Nome = new string[numeroDeProdutos];
        decimal[] Preco = new decimal[numeroDeProdutos];
        decimal Total = 0;
        int preco;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            loadProdutos();
        }
        
        public void loadProdutos()
        {
            Id[0] = 1;
            Nome[0] = "WHEY PROTEIN";
            Preco[0] = 200.00M;

            Id[1] = 2;
            Nome[1] = "YOGURT";
            Preco[1] = 7.00M;

            Id[2] = 3;
            Nome[2] = "GRANOLA";
            Preco[2] = 5.00M;

            Id[3] = 4;
            Nome[3] = "MEL KARO";
            Preco[3] = 9.75M;

            Id[4] = 5;
            Nome[4] = "LEITE DESNATADO";
            Preco[4] = 4.53M;

            Id[5] = 6;
            Nome[5] = "OVO";
            Preco[5] = 0.35M;

            Id[6] = 7;
            Nome[6] = "ALBUMINA";
            Preco[6] = 33.00M;

            Id[7] = 8;
            Nome[7] = "QUEIJO COALHO";
            Preco[7] = 15.73M;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int ind = -1;
            listInfo.Items.Clear();
            txtProduto.Text = "";
            for (int i = 0; i < 8; i++)
            {
                if (txtProduto.Text == Nome[i])
                {
                    listInfo.Items.Add(String.Format("Id:{0}      {1}       R$ {2}", Id[i], Nome[i], Preco[i]));
                    pictureBox1.ImageLocation = "C:/Users/JCNOT/Documents/Visual Studio 2013/Projects/Caixa Jean/Cash Imagens/" + Nome[i] + ".jpg";
                    ind = 0;
                    preco = i;
                }
            }
            if (ind == -1)
                MessageBox.Show("Produto não existe!");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            listPodutos.Items.Add(String.Format("Id:{0}      {1}       R$ {2}", Id[preco], Nome[preco], Preco[preco]));
            Total += Preco[preco];
            txtTotal.Text = Convert.ToString(Total);
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtProduto_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.button1_Click(sender, e);
        }
        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
