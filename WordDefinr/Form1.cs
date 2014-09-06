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
namespace WordDefinr
{
    public partial class WordDefinr : Form
    {
        public WordDefinr()
        {
            InitializeComponent();
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            //string word = txtWords.Text;
            XmlDocument xDoc = new XmlDocument();
            try
            {
                string[] words = txtWords.Text.Split('\n');
                List <string> definitions = new List<string>();

                foreach (string word in words ){
                xDoc.Load("http://www.dictionaryapi.com/api/v1/references/collegiate/xml/" + word + "?key=0cec1fd4-d9d1-4ccc-9ad2-f996151173eb");
                string definition = (xDoc.SelectSingleNode("entry_list/entry/def/dt").InnerText);
                definitions.Add(word+definition);
            }
                txtWords.Text = String.Join("\n", definitions);
                Clipboard.SetText(txtWords.Text);
                lblCopied.Text = "Copied to the clipboard!";
            }
            catch
            {
                MessageBox.Show("I wasn't able to find one of those words in the dictionary, please try again.", "Word not found in the dictionary", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtWords.Text = "";
        }
    }
}
