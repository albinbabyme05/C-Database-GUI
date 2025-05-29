using WeatherApp.Core;

namespace WeatherApp.UI
{
    public partial class Form1 : Form
    {
        WeatherService service = new WeatherService();
        public Form1()
        {
            InitializeComponent();

            lblCondition.Text = "";
            lblTemp.Text = "";
            lblTempFeel.Text = "";

        }

        private void tbCity_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCity.Text))
                return;

            var (lat, lon) = await service.GetCityLatLong(tbCity.Text);

            var (description, temp, temp_feel) = await service.GetWeatherDetailAsync(lat, lon);

            lblCondition.Text = description;
            lblTemp.Text = temp.ToString();
            lblTempFeel.Text = temp_feel.ToString();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCondition.Text = "";
            lblTemp.Text = "";
            lblTempFeel.Text = "";
            tbCity.Clear();
        }

        
    }
}
