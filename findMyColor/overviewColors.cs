/* overviewColors.cs
 * 
 * This form displays all colors in colorString
 * 
 * Created By: Ankit Sadana
 * Created On: 12/01/2014
 * Last Modified By: Ankit Sadana
 * Last Modified On: 12/11/2014
 * 
 * IU Username: asadana
 * 
 * Final Project for A590
 * Part of: findMyColor Project
 */

// Libraries included to run this form
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
    // Main class for this form
    public partial class overviewColors : Form
    {
        // Defining colorString to hold colors sent by mainGame
        String[] colorString;

        // Construction function for this form, accepts an of string
        public overviewColors(String[] colors)
        {
            // Storing colorString as colors string recieved
            colorString = colors;
            // Initializing the form
            InitializeComponent();
        }

        // Function called when the form is loaded
        private void overviewColors_Load(object sender, EventArgs e)
        {
            // Setting the lblColors' Text as the name of colors in colorString
            lblColor1.Text = colorString[0];
            lblColor2.Text = colorString[1];
            lblColor3.Text = colorString[2];
            lblColor4.Text = colorString[3];

            // Setting the colorBox's BackColor as the color name in colorString
            colorBox1.BackColor = Color.FromName(colorString[0]);
            colorBox2.BackColor = Color.FromName(colorString[1]);
            colorBox3.BackColor = Color.FromName(colorString[2]);
            colorBox4.BackColor = Color.FromName(colorString[3]);
        }

        // Function called when "Let's Go Back" button is clicked
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Closes the this form
            this.Close();
        }

        // Function called when the mouse is moved over the button
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            // Increasing the button Width and Height by 4
            btnBack.Width += 4;
            btnBack.Height += 4;
        }

        // Function called when the mouse is moved off the button
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            // Decreasing the button Width and Height by 4
            btnBack.Width -= 4;
            btnBack.Height -= 4;
        }
    }
}
