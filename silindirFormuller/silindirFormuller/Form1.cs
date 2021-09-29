using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace silindirFormuller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region değişkenler

            float yukseklik = Convert.ToSingle(txtyukseklik.Text);

            float yaricap = Convert.ToSingle(txtyarıcap.Text);

            #endregion

            #region hacim

            float hacim = yaricap * yaricap * yukseklik * 3.14f;

            txthacim.Text = Convert.ToString(hacim);

            #endregion

            #region tabanAlani

            float tabanalani = yaricap * yaricap * 3.14f;

            txttabanalani.Text = Convert.ToString(tabanalani);

            #endregion

            #region yanalAlani

            float yanalAlan = 2 * yaricap * yukseklik * 3.14f;

            txtyanalalani.Text = Convert.ToString(yanalAlan);

            #endregion

            #region yuzeyalani

            float yuzeyalani = 2 * tabanalani + yanalAlan;

            txtyuzeyalani.Text = Convert.ToString(yuzeyalani);

            #endregion

        }
        private void btntemizle_Click(object sender, EventArgs e)
        #region temizle

        {
            txthacim.Clear();
            txttabanalani.Clear();
            txtyanalalani.Clear();
            txtyarıcap.Clear();
            txtyukseklik.Clear();
            txtyuzeyalani.Clear();

        }
        #endregion

    }
}
