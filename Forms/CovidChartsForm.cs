using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Group5_PBL.Forms
{
    public partial class CovidChartsForm : Form
    {
        //3 5 8
        //YYYY/MM/DD
        private HttpClient client;
        private StreamWriter sw;
        private StreamReader sr;
        private List<string[]> dataset;
        private Dictionary<DateTime, int> numCases;
        private DateTime startDate;
        private DateTime endDate;

        public CovidChartsForm(DateTime startDate, DateTime endDate)
        {
            client = new HttpClient();
            sw = new StreamWriter($@"{AppContext.BaseDirectory}/covid.csv");
            dataset = new List<string[]>();
            numCases = new Dictionary<DateTime, int>();
            this.startDate = startDate;
            this.endDate = endDate;
            InitializeComponent();
        }

        private async Task ProcessData()
        {
            sr = new StreamReader($@"{AppContext.BaseDirectory}/covid.csv");
            await sr.ReadLineAsync();
            while (sr.Peek() != -1)
            {
                dataset.Add((await sr.ReadLineAsync())?.Split(','));
            }
            sr.Close();
            dataset = dataset.Where(item => item[0] == "PHL").ToList();
            StreamWriter philCovidWriter = new StreamWriter($"{AppContext.BaseDirectory}/phil.csv");
            foreach (var data in dataset)
            {
                foreach (var d in data)
                {
                    await philCovidWriter.WriteAsync($"{d},");
                }
                await philCovidWriter.WriteLineAsync();
            }
        }

        private void PlotPoints()
        {
            var dates = new List<string>();
            foreach (var data in dataset)
            {
                var newDate = data[3].Replace('-', '/');
                if (DateTime.Parse(newDate) >= startDate && DateTime.Parse(newDate) <= endDate)
                {
                    var index = data[5].IndexOf('.');
                    var newNum = int.Parse(data[5].Substring(0, index));
                    numCases.Add(DateTime.Parse(newDate), newNum);
                    dates.Add(newDate);
                }
            }

            ChartValues<ObservableValue> cases = new ChartValues<ObservableValue>();
            foreach (var numCasesValue in numCases.Values)
            {
                cases.Add(new ObservableValue(numCasesValue));
            }
            cartesianChart1.Series.Add(new LineSeries
            {
                Title = "Cases",
                Values = cases,
            });
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = dates
            });
        }

        private async void FormLoad(object sender, EventArgs e)
        {
            var response = await client.GetStringAsync("https://covid.ourworldindata.org/data/owid-covid-data.csv");
            await sw.WriteLineAsync(response);
            sw.Close();
            await ProcessData();
            PlotPoints();
        }
    }
}
