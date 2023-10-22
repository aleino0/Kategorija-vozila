using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Reflection;
using System.IO;

namespace kategorijaVozila
{
    public partial class Form1 : Form
    {
        List<Vozila> VoziloList = new List<Vozila>();
        public Form1()
        {
            InitializeComponent();
        }

        private void fUnos_Click(object sender, EventArgs e)
        {
            try
            {
                if (fModel.Text == "" || fModel.Text == " ")
                {
                    MessageBox.Show("pogrešan unos. Molimo pokušajte ponovo", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Vozila vozilo = new Vozila(fModel.Text, Convert.ToInt32(fGodPr.Text), Convert.ToInt32(fBrKotaca.Text));


                fModel.Clear();
                fGodPr.Clear();
                fBrKotaca.Clear();

                VoziloList.Add(vozilo);
            }
            catch
            {
                MessageBox.Show("pogrešan unos. Molimo pokušajte ponovo", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fGodPr_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(fGodPr.Text, "[^0-9]"))
            {
                MessageBox.Show("Dozvoljeno je unesti samo brojeve.");
                fGodPr.Text = fGodPr.Text.Remove(fGodPr.Text.Length - 1);
            }
        }

        private void fBrKotaca_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(fBrKotaca.Text, "[^0-9]"))
            {
                MessageBox.Show("Dozvoljeno je unesti samo brojeve.");
                fBrKotaca.Text = fBrKotaca.Text.Remove(fBrKotaca.Text.Length - 1);
            }
        }

        private void fIspis_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Vozila v in VoziloList)
            {
                fIspisPod.AppendText(i + ". vozilo\n" + v.ToString() + "\n\n");
                i -= -1;
            }
        }

        private void fObrada_Click(object sender, EventArgs e)
        {
            foreach (Vozila v in VoziloList)
            {
                if (v.Br_kotaca == 2)
                {
                    Moticikl kat = new Moticikl(v.Model, v.God_proivodnje, v.Br_kotaca);
                }
                if (v.Br_kotaca == 4)
                {
                    Moticikl kat = new Moticikl(v.Model, v.God_proivodnje, v.Br_kotaca);
                }
                if (v.Br_kotaca > 4)
                {
                    Moticikl kat = new Moticikl(v.Model, v.God_proivodnje, v.Br_kotaca);
                }
            }
        }

        private void fSpremi_Click(object sender, EventArgs e)
        {
            XDocument newXML = new XDocument(new XElement("Vozila",
                    from xml in VoziloList
                    select new XElement("Vozilo",
                        new XAttribute("Model", xml.Model),
                        new XAttribute("GodinaProizvodnje", xml.God_proivodnje),
                        new XAttribute("BrojKotaca", xml.Br_kotaca))));

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML file (*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.AppendAllText(saveFileDialog1.FileName, newXML.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Pogrešan u spremanje datoteka!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void fUcitaj_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML file (*.xml)|*.xml";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        XElement newXML = XElement.Load(reader);

                        foreach (XElement element in newXML.Elements())
                        {
                            Vozila vz = new Vozila(element.Attribute("Model").Value, Convert.ToInt16(element.Attribute("GodinaProizvodnje").Value), Convert.ToInt16(element.Attribute("BrojKotaca").Value));

                            VoziloList.Add(vz);
                        }
                    }
                }
            }
        }
    }
}
