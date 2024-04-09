using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ_GAME_in_WinForms
{
    /// <summary>
    /// Represents the second form of the quiz game.
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form2"/> class.
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to the first form when the navigation button is clicked.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void navigateToForm1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        /// <summary>
        /// Shows a message indicating the quiz is inactive when the button is clicked.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void showQuizB(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry! Quiz Inactive");
        }
    }
}
