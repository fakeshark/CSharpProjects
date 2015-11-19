using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibs
{
    public partial class frmMadLibs : Form
    {
        public frmMadLibs()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                if (IsValidData())
                {
                    string pluralNoun1 = txtPluralNoun1.Text;
                    string partOfBody = txtPartOfBody.Text;
                    string verb = txtVerb.Text;
                    string pluralNoun2 = txtPluralNoun2.Text;
                    string politician = txtPolitician.Text;
                    string adjective = txtAdjective.Text;

                    MessageBox.Show("Friends, Romans, " + pluralNoun1 + " lend me your " + partOfBody + " I come to " + verb + " Caesar, not to praise him.\n" +
                    "The evil that men do lives after them. The good is oft interred with their " + pluralNoun2 + ".\n  So let it be with " + politician + " The noble Brutus;" +
                    "Hath told you Caesar was " + adjective + ";\n If it were so, it was a grievous fault, And grievously hath Caesar answer'd it\n", "Mad Libs Results:");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
            
        }

        public bool IsValidData()
        {
            return
            IsPresent(txtPluralNoun1, "Plural Noun 1") &&
            IsPresent(txtPartOfBody, "Part of Body") &&
            IsPresent(txtVerb, "Verb") &&
            IsPresent(txtPluralNoun2, "Plural Noun 2") &&
            IsPresent(txtPolitician, "Politician") &&
            IsPresent(txtAdjective, "Adjective");
        }

        public bool IsPresent(TextBox textbox, string name)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(name + " is a reqired field.", "Entry Error:");
                textbox.Focus();
                return false;
            }
            return true;
        }

    }
}
