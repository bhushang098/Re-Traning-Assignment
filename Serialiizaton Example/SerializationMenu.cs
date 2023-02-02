using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serialiizaton_Example
{
    public partial class SerializationMenu : Form
    {
        public SerializationMenu()
        {
            InitializeComponent();
        }

        private void btn_binary_ser_Click(object sender, EventArgs e)
        {
            Product p = new Product(10, "Teddy", 23674, "Soft And Beautiful Teddy Toy");
            BinaryFormatter b = new BinaryFormatter();

            FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\product.txt", FileMode.Create, FileAccess.ReadWrite);

            b.Serialize(fs, p);
            fs.Close();
            MessageBox.Show("File Created");
        }

        private void btn_binary_deser_Click(object sender, EventArgs e)
        {
            Product prod;
            try{
                BinaryFormatter b = new BinaryFormatter();
                FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\product.txt", FileMode.Open, FileAccess.ReadWrite);
                prod = (Product) b.Deserialize(fs);
                fs.Close();

                MessageBox.Show(String.Format("Deserialized Product: \n Id : {0} \n Name : {1} \n Price : {2} \n Description : {3}",prod.Id,prod.Name,prod.Price,prod.Description));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xml_ser_Click(object sender, EventArgs e)
        {
            Product p = new Product(10, "Teddy", 23674, "Soft And Beautiful Teddy Toy");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
            FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\product.xml", FileMode.Create, FileAccess.ReadWrite);

            xmlSerializer.Serialize(fs, p);
            fs.Close();
            MessageBox.Show("File Created");

        }

        private void btn_xml_deser_Click(object sender, EventArgs e)
        {
            Product prod;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\product.xml", FileMode.Open, FileAccess.ReadWrite);
                prod = (Product)xmlSerializer.Deserialize(fs);
                fs.Close();

                MessageBox.Show(String.Format("Deserialized Product: \n Id : {0} \n Name : {1} \n Price : {2} \n Description : {3}", prod.Id, prod.Name, prod.Price, prod.Description));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
