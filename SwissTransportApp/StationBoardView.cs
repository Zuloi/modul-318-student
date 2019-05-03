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
    public partial class StationBoardView : Form
    {
        #region Membervariable
        Transport transport = new Transport();
        Stations stations = new Stations();
        StationBoardRoot stationBoardRoot = new StationBoardRoot();

        #endregion
        #region Initialize
        public StationBoardView()
        {
            InitializeComponent();
        }
        #endregion
        #region Methoden
        private void StationFill(object sender, EventArgs e)
        {
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
                            MessageBox.Show("Ungültige Eingabe");
                        }
                    }
                }
            }
        }

        private void SearchConnection_Click(object sender, EventArgs e)
        {
            stationBoardRoot = transport.GetStationBoard(FromStation.Text);
            DataViewGrid.Rows.Clear();
            try
            {
                 foreach(StationBoard stationBoard in stationBoardRoot.Entries)
                 {
                      DataViewGrid.Rows.Add(Convert.ToDateTime(stationBoard.Stop.Departure).ToString("HH:mm"), FromStation.Text, stationBoard.Number, stationBoard.Operator, stationBoard.To);
                 }
            }
            catch (Exception)
            {
                MessageBox.Show("Ungültige eingaben.");
            }
        }
        #endregion
    }
}
