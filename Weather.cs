using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Data.SqlClient;

namespace WeatherHRW
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();           
        }

        

        private async void getWeatherButton_Click(object sender, EventArgs e)
        {
            try { 
            WebRequest request = 
                WebRequest.Create
                ("http://api.openweathermap.org/data/2.5/weather?id=" + weatherTextBox.Text + "&appid=b07469cf1327b57266db32c8e7ef226c");

            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = await request.GetResponseAsync();
            string answer = string.Empty;

            using(Stream s = response.GetResponseStream())
            {
                using(StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }
            response.Close();

            jsonRichTextBox.Text = answer;

            OpenWeather.OpenWeather ow = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);

            iconPanel.BackgroundImage = ow.weather[0].Icon;

            tempLabel.Text = "Temp:" + ow.main.temp.ToString("00.0") + " C";

            descriptionLabel.Text = ow.weather[0].description;

            hummidityLabel.Text = "Hummidity: " + ow.main.humidity.ToString("00.0") + " %";

            pressureLabel.Text = "Pressure: " + ow.main.pressure.ToString("00,0") + " mm";

            nameLabel.Text = ow.name + ", " + ow.sys.country;

            speedLabel.Text = "Speed " + ow.wind.speed.ToString("00.0") + " mps  ";

            degLabel.Text = "Direction " + ow.wind.deg.ToString("0") + " deg";

                DateTime date = DateTime.Now;
                string description = "Weather in: " + ow.name;
                Request req = new Request(date, description);
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = @"Integrated Security=SSPI;
                                            Persist Security Info=False;
                                            Initial Catalog=RequestsDB;
                                            Data Source=(local)\SQLEXPRESS";
                    try
                    {
                        conn.Open();
                        string sql = string.Format("Insert Into Requests" +
                                   "(Date, Description) Values(@Date, @Description)");
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@Date", date);
                            cmd.Parameters.AddWithValue("@Description", description);
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void timeZoneButton_Click(object sender, EventArgs e)
        {
            try
            {
                WebRequest request =
                WebRequest.Create
                ("http://api.openweathermap.org/data/2.5/weather?zip=" + zipTextBox.Text + "," + countryTextBox.Text + "&appid=b07469cf1327b57266db32c8e7ef226c");

                request.Method = "POST";
                request.ContentType = "application/x-www-urlencoded";

                WebResponse response = await request.GetResponseAsync();
                string answer = string.Empty;

                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        answer = await reader.ReadToEndAsync();
                    }
                }
                response.Close();
                OpenWeather.OpenWeather ow = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);
                if(ow.timezone < 0)
                { 
                    MessageBox.Show(ow.name + ", " + ow.sys.country + ", " + "UTC " + (ow.timezone / 3600).ToString("0"));
                }
                else
                {
                    MessageBox.Show(ow.name + ", " + ow.sys.country + ", " + "UTC +" + (ow.timezone / 3600).ToString("0"));
                }

                DateTime date = DateTime.Now;
                string description = "Time zone of: " + ow.name + ow.sys.country;
                Request req = new Request(date, description);
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = @"Integrated Security=SSPI;
                                            Persist Security Info=False;
                                            Initial Catalog=RequestsDB;
                                            Data Source=(local)\SQLEXPRESS";
                    try
                    {
                        conn.Open();
                        string sql = string.Format("Insert Into Requests" +
                                   "(Date, Description) Values(@Date, @Description)");
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@Date", date);
                            cmd.Parameters.AddWithValue("@Description", description);
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch(WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Weather_Load(object sender, EventArgs e)
        {
            
        }

        private async void requestsListButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"Integrated Security=SSPI;
                                            Persist Security Info=False;
                                            Initial Catalog=RequestsDB;
                                            Data Source=(local)\SQLEXPRESS";
                try
                {
                    jsonRichTextBox.Clear();
                    conn.Open();
                    string sql = "SELECT * FROM Requests";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    while (dr.Read())
                    {
                        jsonRichTextBox.Text += dr[1].ToString() + " " + dr[2].ToString() + " " + Environment.NewLine;
                    }
                    conn.Close(); 
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
