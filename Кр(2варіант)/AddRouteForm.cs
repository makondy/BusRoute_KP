using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кр_2варіант_
{
    public partial class AddRouteForm : Form
    {
        public BusRoute NewRoute { get; private set; }

        public AddRouteForm()
        {
            InitializeComponent();
        }

        public AddRouteForm(BusRoute route) : this()
        {
            // Заповнення полів для редагування
            txtRouteNumber.Text = route.RouteNumber.ToString();
            txtDestination.Text = route.Destination;
            cmbStops.Items.AddRange(route.Stops);
            dtpDepartureTime.Value = route.DepartureTime;
            txtSeatsAvailable.Text = route.SeatsAvailable.ToString();
            if (route is ExpressRoute) rbExpress.Checked = true;
            else rbLocal.Checked = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Зчитування даних з полів
            int routeNumber = int.Parse(txtRouteNumber.Text);
            string destination = txtDestination.Text;
            string[] stops = cmbStops.Text.Split(',');
            DateTime departureTime = dtpDepartureTime.Value;
            int seatsAvailable = int.Parse(txtSeatsAvailable.Text);

            if (rbExpress.Checked)
            {
                NewRoute = new ExpressRoute(routeNumber, destination, stops, departureTime, seatsAvailable, 80); // Середня швидкість 80 км/год
            }
            else
            {
                NewRoute = new LocalRoute(routeNumber, destination, stops, departureTime, seatsAvailable, 10); // Стоянка 10 хв
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
