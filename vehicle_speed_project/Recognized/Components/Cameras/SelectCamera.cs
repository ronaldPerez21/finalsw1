using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video.DirectShow;

namespace vehicle_speed_project.Recognized.Components
{
    public partial class SelectCamera : Form
    {
        private FilterInfoCollection myDevices;
        private bool existDevices = false;
        private int _device;
        public int device
        {
            get { return _device; }
        }
        public SelectCamera()
        {
            InitializeComponent();
        }

        private void SelectCamera_Load(object sender, EventArgs e)
        {
            loadDevices();
        }



        private void btnAccept_Click(object sender, EventArgs e)
        {
            _device = comboBoxChooseCamera.SelectedIndex;
        }

        public void loadDevices()
        {
            this.myDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (this.myDevices.Count > 0)
            {
                for (int i = 0; i < this.myDevices.Count; i++)
                    comboBoxChooseCamera.Items.Add(this.myDevices[i].Name.ToString());
                comboBoxChooseCamera.Text = this.myDevices[0].Name.ToString();
                this.existDevices = true;
            }
            else this.existDevices = false;
        }
    }
}
