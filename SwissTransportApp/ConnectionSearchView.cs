using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SwissTransportApp
{
    public partial class ConnectionSearchView : Form
    {
        
        
        
       
        public ConnectionSearchView()
        {
            InitializeComponent();
        }

      

        private void ConnectionSearch_Load(object sender, EventArgs e)
        {
            Date.Format = DateTimePickerFormat.Custom;
            Date.CustomFormat = "yyyy-MM-dd";

            Time.Format = DateTimePickerFormat.Custom;
            Time.CustomFormat = "HH:mm";
        }

        private void Exchange_Click(object sender, EventArgs e)
        {
            string ChangeFromStation = FromStation.Text;
            string ChangeToStation = ToStation.Text;
            FromStation.Text =  ChangeToStation;
            ToStation.Text = ChangeFromStation;   
        }

        private void SearchConnection_Click(object sender, EventArgs e)
        {          
            Transport transport = new Transport();
            Connections connections = transport.GetConnections(FromStation.Text, ToStation.Text, Date.Text, Time.Text);
            DataViewGrid.Rows.Clear();
            

            foreach (Connection connection in connections.ConnectionList)
            {
                this.DataViewGrid.Rows.Add(Convert.ToDateTime(connection.From.Departure).ToString("HH:mm"), connection.From.Station.Name, connection.From.Platform, connection.Duration, connection.To.Station.Name, connection.To.Platform);
               

            }

        }

      



    

   

        private void StationFill(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            Stations stations = new Stations();
            ComboBox userInput = (ComboBox)sender;
            

            if (userInput.Text.Length >= 1)
            {
                stations = transport.GetStations(userInput.Text);
                List<Station> stationList = stations.StationList;
                

                if (stationList.Count > 0)
                {
                    foreach (Station station in stationList)
                    {
                        try
                        {
                            userInput.Items.Add(station.Name);
                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("");
                        }
                    }
                }
            }
        }



      

        private void FromLocation_Click(object sender, EventArgs e)
        {
            if (FromStation.Text != null)
            {
                try
                {
                    Process.Start("https://www.google.com/maps/search/?api=1&query=" + FromStation.Text);
                }
                catch
                {
                    MessageBox.Show("Fehler");
                }
            }
            else
            {
                MessageBox.Show("Der Abfahrtsort ist ungültig.");
            }
        }

        private void ToLocation_Click(object sender, EventArgs e)
        {
            if (ToStation.Text != null)
            {
                try
                {
                    Process.Start("https://www.google.com/maps/search/?api=1&query=" + ToStation.Text);
                }
                catch
                {
                    MessageBox.Show("Fehler");
                }
            }
            else
            {
                MessageBox.Show("Der Ankunftsort ist ungültig.");
            }
        }
    }
    
}
