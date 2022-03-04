using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Something
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void disney_AttractionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disney_AttractionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database4DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database4DataSet.Disney_Attractions' table. You can move, or remove it, as needed.
            this.disney_AttractionsTableAdapter.Fill(this.database4DataSet.Disney_Attractions);

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    /*
                    string Family_friendly = family_FriendlyCheckBox.Checked.ToString();
                    string Disney_Land = disney_LandCheckBox.Checked.ToString();
                    string Disney_World = disney_WorldCheckBox.Checked.ToString();
                    string Within_a_100_miles = within_a_100_milesCheckBox.Checked.ToString();
                    string Daytime = daytimeCheckBox.Checked.ToString();
                    string Good_Ratings = good_RatingsCheckBox.Checked.ToString();
                    string Description = descriptionComboBox.SelectedItem.ToString();
                    string Cost = costComboBox.SelectedItem.ToString();

                    */

                    // Query database  
                    var contactDetails =
                   from c in database4DataSet.Disney_Attractions
                   where c.Family_Friendly == true
                   && c.Within_a_100_miles == true
                   
                   select c;

                    foreach (Database4DataSet.Disney_AttractionsRow item in contactDetails)
                    {
                        textBox1.Text += item.Description + "/"; 
                        costComboBox.Text +=  item.Cost + "/";
                    }
                }


                catch (Exception ex)
                {

                }
            }
        }

        private void disney_AttractionsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void good_RatingsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
