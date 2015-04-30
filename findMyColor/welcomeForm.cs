/* welcomeForm.cs
 * 
 * This is the welcome splash screen for this application.
 * 
 * Created By: Ankit Sadana
 * Created On: 12/09/2014
 * Last Modified By: Ankit Sadana
 * Last Modified On: 12/11/2014
 * 
 * IU Username: asadana
 * 
 * Final Project for A590
 * Part of: findMyColor Project
 */

// Libraries being used by this form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name of the project: findMyColor
namespace findMyColor
{
    // Main class of this form
    public partial class welcomeForm : Form
    {
        // Constructor fucntion of this form
        public welcomeForm()
        {
            // Initializing the form
            InitializeComponent();
        }

        // Function called when the "Let's Play!" button is clicked
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Closing this form
            this.Close();
        }

        // Function called when the user moves the mouse over or off of either of the labels
        private void lblColorChange(object sender, EventArgs e)
        {
            // A string array is defined with all 8 colors used in this application
            String[] allColors = { "Red", "Blue", "Green", "Yellow", "Orange", "Purple", "Pink", "Aqua" };

            // Using random variable to produce a random string index in randIndex
            Random randVar = new Random();
            int randIndex = 0;
            // A random number is generated between 0 and length of allColors array
            randIndex = randVar.Next(0, allColors.Length);
            // ForeColor of both labels is set to the randIndex-th Color from allColors
            lblWelcome.ForeColor = Color.FromName(allColors[randIndex]);
            lblMadaeBy.ForeColor = Color.FromName(allColors[randIndex]);
        }

    }
}
