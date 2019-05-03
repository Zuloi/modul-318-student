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
    public partial class StationBoard : Form
    {
        public StationBoard()
        {
            InitializeComponent();
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

        private void SearchConnection_Click(object sender, EventArgs e)
        {
            /*  Transport transport = new Transport();
              StationBoardRoot stationboard = transport.GetStationBoard(FromStation.Text);

              foreach(StationBoard StationBoard in stationboard.Entries)
              {
                  this.DataViewGrid.Rows.Add();


              }*/

            Transport transport = new Transport();
            
            StationBoardRoot stationBoardRoot = new StationBoardRoot();
            //stationBoardEntries = transport.GetStationBoard(FromStation.Text).Entries;
            /* try
             {
                 stationBoardRoot = transport.GetStationBoard(FromStation.Text);

                 foreach ( stationBoard in stationBoardRoot.Entries)
                 {
                      DataViewGrid.Rows.Add(Convert.ToDateTime(stationBoard.Stop.Departure).ToString("HH:mm"), stationBoard.To);
                 }
             }
                  catch (Exception )
                 {
                     MessageBox.Show(FromStation.Text);
                  }
             /* Stations stations = new Stations();

          stations = transport.GetStations(FromStation.Text);
          List<Station> stationList = stations.StationList;
          foreach (Station station in stationList)
          {
              this.DataViewGrid.Rows.Add(station.Station.Name);

          }*/
        }
    }
}
