using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern_00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int grade = 1;
            try
            {
                grade = Convert.ToInt32(txtBxGrade.Text);
            }
            catch
            {
                txtBxGrade.Text = grade.ToString();

            }
        }
    }


    public class User
    {
        public int Grade = 1;
        public StateContext State;
        public User()
        {

        }
        public void SetState(StateContext state)
        {
            State = state;
        }
        public string GetLevelString()
        {
            return this.
        }
    }

    public abstract class StateContext
    {
        
        public abstract string GetLevelString();
    } 
}
