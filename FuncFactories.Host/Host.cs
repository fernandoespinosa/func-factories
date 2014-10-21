using System.Text;
using CP.KwikEMart.NUnit.Web.Http.SelfHost;
using log4net;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncFactories.Host
{
    public partial class Host : Form
    {
        public Host()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void buttonBarBlast_Click(object sender, EventArgs e)
        {
            await BlastAsync("http://localhost:8001/bar");
        }

        private async void buttonFooBlast_Click(object sender, EventArgs e)
        {
            await BlastAsync("http://localhost:8001/foo");
        }

        private async Task BlastAsync(string uri)
        {
            using (var client = new HttpClient())
            {
                for (var i = 0; i < 1000; i++)
                {
                    var response = await client.GetAsync(uri);
                    var stringBuilder = new StringBuilder();
                    stringBuilder.AppendFormat("Sending request #{0} to {1}: {2}", i, uri, response.StatusCode);
                    stringBuilder.AppendLine();
                    stringBuilder.AppendFormat("Response: {0}", await response.Content.ReadAsStringAsync());
                    this.textBox.Text = stringBuilder.ToString();
                }
            }
        }
    }
}
