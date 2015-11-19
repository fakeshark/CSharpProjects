using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public partial class frmStudentScores : Form
    {
        List<string> studentList = new List<string>();
        List<List<decimal>> scoresList = new List<List<decimal>>();
        List<decimal> SubList = new List<decimal>();

        public frmStudentScores()
        {
            InitializeComponent();
        }

        private void frmStudentScores_Load(object sender, System.EventArgs e)
        {
            studentList.Add("Joel Murach");
            studentList.Add("Doug Lowel");
            studentList.Add("Anne Boehm");

            scoresList.Add(new List<decimal> { 97, 71, 83 });
            scoresList.Add(new List<decimal> { 99, 93, 97 });
            scoresList.Add(new List<decimal> { 100, 100, 100 });

            refreshListBox();
                 
         }

        private void refreshListBox()
        {
            lbxStudents.Items.Clear();

            string name = "";
            string score = "";
            string scores = "";
            for (int i = 0; i < studentList.Count; i++)
            {
                name = studentList[i];
                for (int j = 0; j < scoresList[i].Count; j++)
                {
                    score = scoresList[i][j].ToString();
                    scores = scores + " | " + score;
                }

                lbxStudents.Items.Add((name + scores));
                scores = "";
            }
        }

        private void btnAddNew_Click(object sender, System.EventArgs e)
        {
            Form updateStudentScores = new frmUpdateStudentScores();
            DialogResult selectedButton = updateStudentScores.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                studentList.Add((string)updateStudentScores.Tag);
                refreshListBox();
            }


        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            Form updateStudentScores = new frmUpdateStudentScores();
            DialogResult selectedButton = updateStudentScores.ShowDialog();
            //if (selectedButton == DialogResult.OK)
            //{
            //    lblPaymentBox.Text = (string)paymentForm.Tag;
            //}
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            Form updateStudentScores = new frmUpdateStudentScores();
            DialogResult selectedButton = updateStudentScores.ShowDialog();
            //if (selectedButton == DialogResult.OK)
            //{
            //    lblPaymentBox.Text = (string)paymentForm.Tag;
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal calculateTotal(int _currSelectedIndex)
        {
            decimal totalScore = 0m;

            for (int i = 0; i < (scoresList[_currSelectedIndex].Count); i++)
            {
                totalScore += Convert.ToDecimal( scoresList[_currSelectedIndex][i] );
            }

            return totalScore;

        }

        private void lbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currSelectedIndex = lbxStudents.SelectedIndex;
            int currScoreCount = scoresList[currSelectedIndex].Count;
            decimal currTotal = calculateTotal(currSelectedIndex);

            txtScoreTotal.Text = Convert.ToString(currTotal);
            txtScoreCount.Text = Convert.ToString(currScoreCount);
            txtAverage.Text = Convert.ToString(currTotal / currScoreCount);

        }

    }
}