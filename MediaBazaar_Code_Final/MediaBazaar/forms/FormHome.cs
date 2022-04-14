using MediaBazaar.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.forms
{
    public partial class FormHome : Form
    {
        //data from the login form
        private Manager managerLoggedIn;

        private EmployeeAdministration empAdmin;
        private ProductAdministration prodAdmin;

        //use of file with the announcements
        List<Announcement> announcements;
        string fileName = "Announcements.csv";
        public FormHome(EmployeeAdministration empAdmin, Manager managerLoggedIn)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.managerLoggedIn = managerLoggedIn;
            //loading announcements from a file on startup
            this.announcements = new List<Announcement>();
            this.LoadNewsFromFile();
            this.prodAdmin = new ProductAdministration("Product Department");

            //see employees in listbox
            foreach(FreeDay f in DatabaseHelper.GetAllFreeDays())
            {
                if(f.Date == DateTime.Today && f.Shift != null && f.Status == "ACCEPTED")
                {
                    lbEmplHoliday.Items.Add(this.empAdmin.GetEmployeeById(f.Id).Name);
                }
                else if (f.Date == DateTime.Today && f.SickDay == true && f.Status == "ACCEPTED")
                {
                    lbEmplSick.Items.Add(this.empAdmin.GetEmployeeById(f.Id).Name);
                }
            }
        }
        public void LoadNewsFromFile()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            lbNews.Items.Clear();
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                announcements = (List<Announcement>)bf.Deserialize(fs);
            }
            catch (IOException)
            { MessageBox.Show("Error reading file"); }
            finally
            {
                if (fs != null)

                { fs.Close(); }
            }
            this.lbNews.Items.Clear();
            foreach (Announcement a in announcements)
            {
                lbNews.Items.Add(a);
            }
        }
        public void SaveNewsToFile()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                //Initialize stream for writing to file
                fs = new FileStream("Announcements.csv", FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();

                // Write values to file

                bf.Serialize(fs, this.announcements);

            }
            catch (IOException ex)
            {
                MessageBox.Show("Something went wrong while accessing the file. Please check if there is no other application that opened the file");
            }
            catch (SerializationException ex)
            {
                MessageBox.Show("Something went wrong. You did not succeed with serialization.");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
        // --BUTTONS FOR THE ANNOUNCEMENTS --

        private void btnSaveAnnouncements_Click(object sender, EventArgs e)
        {
            if (tbNewAnnouncement.Text == "") { MessageBox.Show("Add the body to your news."); }
            else
            {
                Announcement ann = new Announcement(this.tbNewAnnouncement.Text);
                this.announcements.Add(ann);
                this.lbNews.Items.Add(ann);
                SaveNewsToFile();
                MessageBox.Show("Announcement successfully saved!");
                this.tbNewAnnouncement.Clear();
            }
        }

        private void btnUpdateNews_Click(object sender, EventArgs e)
        {
            int index = lbNews.SelectedIndex;
            if (index != -1)
            {
                String updatedAnnouncement = tbNewAnnouncement.Text;
                lbNews.Items.RemoveAt(index);
                announcements.RemoveAt(index);
                lbNews.Items.Insert(index, updatedAnnouncement);
                announcements.Insert(index, new Announcement(updatedAnnouncement));
                SaveNewsToFile();
            }
            else { MessageBox.Show("Please select an announcement to update!"); }
        }

        private void btnRemoveNews_Click(object sender, EventArgs e)
        {
            int selectedAnnouncement = lbNews.SelectedIndex;
            if (selectedAnnouncement != -1)
            {
                announcements.RemoveAt(selectedAnnouncement);
                lbNews.Items.RemoveAt(selectedAnnouncement);
                SaveNewsToFile();
                tbNewAnnouncement.Clear();
            }
        }

        private void lbNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNewAnnouncement.Text = Convert.ToString(lbNews.SelectedItem);
        }
    }
}
