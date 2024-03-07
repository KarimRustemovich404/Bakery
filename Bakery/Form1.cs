using System;
using System.IO.Pipes;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using System.IO;

namespace Bakery
{
    public partial class OpeningForm : Form
    {
        public OpeningForm()
        {
            InitializeComponent();

            this.ControlBox = false;

            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("root");
            doc.AppendChild(root);

            XmlElement borodinskyBread = doc.CreateElement("БородинскийХлеб");
            root.AppendChild(borodinskyBread);

            XmlElement compoundOfBorodinsky = doc.CreateElement("Состав");
            compoundOfBorodinsky.InnerText = "Стандартный состав бородинского хлеба";
            borodinskyBread.AppendChild(compoundOfBorodinsky);

            XmlElement dateOfManufacture = doc.CreateElement("ДатаИзготовления");
            dateOfManufacture.InnerText = "09.03.2007";
            borodinskyBread.AppendChild(dateOfManufacture);

            doc.Save("Бородинский хлеб.xml");

            var personJson = new
            {
                borodinskyBread = "БородинскийХлеб",
                dateOfManufacture = "09.03.2007"
            };

            string json = JsonConvert.SerializeObject(borodinskyBread);
            File.WriteAllText("Бородинский хлеб.json", json);
        }

        #region Methods
        private void CloseAnApp(object sender, EventArgs e)
        {
            Close();
        }

        private void DownloadFile(object sender, EventArgs e)
        {

            Download_File.Filter = "XML files (*.xml)|*.xml|JSON files (*.json)|*.json";
            Download_File.FilterIndex = 1;
            Download_File.RestoreDirectory = true;

            if (Download_File.ShowDialog() == DialogResult.OK)
            {
                string filePath = Download_File.FileName;

                if (filePath.EndsWith(".xml"))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(filePath);

                    MessageBox.Show("XML: " + xmlDoc.InnerXml);
                }
                else if (filePath.EndsWith(".json"))
                {
                    string json = System.IO.File.ReadAllText(filePath);

                    dynamic jsonObj = JsonConvert.DeserializeObject(json);
                    MessageBox.Show("JSON: " + jsonObj.ToString());
                }
            }
        }
        #endregion

    }
}
