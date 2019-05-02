using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SwissTransportApp
{
    public partial class ConnectionSearch : Form
    {
        public ConnectionSearch()
        {
            InitializeComponent();
        }

    

        private void ConnectionSearch_Load(object sender, EventArgs e)
        {
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.CustomFormat = "dd, MM, yy";

            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "HH:mm ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string ChangeFromStation = FromStation.Text;
            string ChangeToStation = ToStation.Text;
            FromStation.Text =  ChangeToStation;
            ToStation.Text = ChangeFromStation;   
        }

        private void SearchConnection_Click(object sender, EventArgs e)
        {
            Transport transport = new Transport();        
            Connections connections = transport.GetConnections(FromStation.Text , ToStation.Text);
            List<Connection> connectionList = connections.ConnectionList;


            foreach (Connection connection in connectionList)
            {
                this.DataViewGrid.Rows.Add(connection.From.Station.Name, connection.From.Platform, connection.To.Station.Name);
               

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
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
