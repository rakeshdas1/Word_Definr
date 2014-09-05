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
                string [] words = txtWords.Text.Split('\n');
                foreach (string word in words ){
                xDoc.Load("http://www.dictionaryapi.com/api/v1/references/collegiate/xml/" + word + "?key=0cec1fd4-d9d1-4ccc-9ad2-f996151173eb");
                txtWords.Text = (xDoc.SelectSingleNode("entry_list/entry/def/dt").InnerText)+(Environment.NewLine);
               
                Clipboard.SetText(txtWords.Text);
                lblCopied.Text = "Copied to the clipboard!";
            }
            }
            catch
            {
                MessageBox.Show("That is not a word in the dictionary, please try again.", "Word not found in the dictionary", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        
        }
    }
}
