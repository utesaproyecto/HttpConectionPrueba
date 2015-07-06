using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace httpconection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
WebRequest request = WebRequest.Create("http://8texpress-utesaproyecto.rhcloud.com/8tWeb/web/prueba/hola");
            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();
            MessageBox.Show(((HttpWebResponse)response).StatusDescription);

            Stream datosStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(datosStream);

            string responseFromServer = reader.ReadToEnd();
            MessageBox.Show("Link: " + responseFromServer);
            reader.Close();
            response.Close();
        }
  
    
    
    
    }
}
