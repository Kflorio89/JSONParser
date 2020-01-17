using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var client = new RestClient("");
        }
        
        private void cmdDeserialize_Click(object sender, EventArgs e)
        {
            //debugOutput(txtInput.Text);
            deserializeJSON(txtInput.Text);
        }

        private void cmdCLear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
        }

        private void deserializeJSON(string strJSON)
        {
            try
            {
                var jResponse = JsonConvert.DeserializeObject<OACResponse>(strJSON);

                debugOutput("EsetNumber is: " + jResponse.EsetNumber);
                debugOutput("SerialNumber is: " + jResponse.SerialNumber);
                debugOutput("JobNumber is: " + jResponse.JobNumber);
                debugOutput("FileContent is: " + jResponse.Reports.Report[0].FileContent);

            }
            catch(Exception ex)
            {
                debugOutput("Error: " + ex.Message.ToString());
            }
        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine(strDebugText + Environment.NewLine);
                txtOutput.Text = txtOutput.Text + strDebugText + Environment.NewLine;
                txtOutput.SelectionStart = txtOutput.TextLength;
                txtOutput.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString() + Environment.NewLine);
            }
        }

    }
}
