using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DovizKurlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            lstBoxDoviz.Items.Clear();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlElement rooteleman = xmldoc.DocumentElement; //tüm dokuman
            XmlNodeList liste = rooteleman.GetElementsByTagName("Currency");
            List<Doviz> dlist = new List<Doviz>();
            foreach (var item in liste)
            {
                Doviz d = new Doviz();
                XmlElement currency = (XmlElement)item;
                string isim = currency.GetElementsByTagName("Isim").Item(0).InnerText;
                d.DovizAd = isim;
                string AlisFiyat = currency.GetElementsByTagName("ForexBuying").Item(0).InnerText;
                string SatisFiyat = currency.GetElementsByTagName("ForexSelling").Item(0).InnerText;
                string Birim = currency.GetElementsByTagName("Unit").Item(0).InnerText;

                if (!string.IsNullOrEmpty(AlisFiyat))
                {
                    d.AlisFiyat = Convert.ToDecimal(AlisFiyat);
                }
                if (!string.IsNullOrEmpty(SatisFiyat))
                {
                    d.SatisFiyat = Convert.ToDecimal(SatisFiyat);
                }
                if (!string.IsNullOrEmpty(Birim))
                {
                    d.Birim = Convert.ToInt32(Birim);
                }
                lstBoxDoviz.Items.Add(d);
                dlist.Add(d);
            }
            dataGridViewDoviz.DataSource = dlist;
            int i = 0;
            foreach (var item in dlist)
            {
                try
                {
                    dataGridViewDoviz2.Rows.Add();
                    dataGridViewDoviz2.Rows[i].Cells[0].Value = item.DovizAd;
                    dataGridViewDoviz2.Rows[i].Cells[1].Value = item.SatisFiyat;
                    i++;
                }
                catch (Exception)
                {

                }
            }
        }

        private void lstBoxDoviz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doviz secilenDoviz = (Doviz)lstBoxDoviz.SelectedItem;
            lblAlis.Text = secilenDoviz.AlisFiyat.ToString();
            lblSatis.Text = secilenDoviz.SatisFiyat.ToString();
            lblBirim.Text = secilenDoviz.Birim.ToString();
        }
    }
}

