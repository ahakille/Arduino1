using ArduinoDriver.SerialProtocol;
using ArduinoUploader.Hardware;
using System;
using System.Windows.Forms;

namespace Arduino1
{
    public partial class Main : Form
    {
        ArduinoDriver.ArduinoDriver driver = new ArduinoDriver.ArduinoDriver(ArduinoModel.UnoR3, "COM3", true);
        public Main()
        {
            InitializeComponent();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            //driver.Send(new (,ArduinoDriver.DigitalValue.High));
            driver.Send(new DigitalWriteRequest(3, ArduinoDriver.DigitalValue.High));
            //driver.Send(new AnalogWriteRequest(3, 1));
            var test = driver.Send(new DigitalReadRequest(3));
            lbtext.Text = test.PinValue.ToString();
            vxl1.ImageLocation = @"C:\Users\ahakille\Documents\visual studio 2017\Projects\Arduino1\Resources\2vänster.png";

        }

        private void btnAv_Click(object sender, EventArgs e)
        {
            driver.Send(new DigitalWriteRequest(3, ArduinoDriver.DigitalValue.Low));
           
            var test = driver.Send(new DigitalReadRequest(3));
            lbtext.Text = test.PinValue.ToString();
            vxl1.ImageLocation = @"C:\Users\ahakille\Documents\visual studio 2017\Projects\Arduino1\Resources\2raka.png";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            driver.Send(new DigitalWriteRequest(3, ArduinoDriver.DigitalValue.High));
            driver.Send(new AnalogWriteRequest(3, 1));
            driver.Send(new DigitalWriteRequest(3, ArduinoDriver.DigitalValue.Low));
            driver.Send(new DigitalWriteRequest(4, ArduinoDriver.DigitalValue.High));
            driver.Send(new AnalogWriteRequest(4, 1));
            driver.Send(new DigitalWriteRequest(4, ArduinoDriver.DigitalValue.Low));
            driver.Send(new DigitalWriteRequest(5, ArduinoDriver.DigitalValue.High));
            driver.Send(new AnalogWriteRequest(5, 1));
            driver.Send(new DigitalWriteRequest(5, ArduinoDriver.DigitalValue.Low));
            driver.Send(new DigitalWriteRequest(6, ArduinoDriver.DigitalValue.High));
            driver.Send(new AnalogWriteRequest(6, 1));
            driver.Send(new DigitalWriteRequest(6, ArduinoDriver.DigitalValue.Low));
        }

        private void vxl2höger_Click(object sender, EventArgs e)
        {
            driver.Send(new DigitalWriteRequest(4, ArduinoDriver.DigitalValue.High));
            vxl2.ImageLocation = @"C:\Users\ahakille\Documents\visual studio 2017\Projects\Arduino1\Resources\2höger.png";
        }

        private void vl2btnrak_Click(object sender, EventArgs e)
        {
            driver.Send(new DigitalWriteRequest(4, ArduinoDriver.DigitalValue.Low));
            vxl2.ImageLocation = @"C:\Users\ahakille\Documents\visual studio 2017\Projects\Arduino1\Resources\2raka.png";
        }
        private void vxl3h_Click(object sender, EventArgs e)
        {
            driver.Send(new DigitalWriteRequest(4, ArduinoDriver.DigitalValue.Low));
            
            pictureBox2.ImageLocation = @"C:\Users\ahakille\Documents\visual studio 2017\Projects\Arduino1\Resources\2raka.png";
        }
        private void vxl3t_Click(object sender, EventArgs e)
        {
            driver.Send(new DigitalWriteRequest(5, ArduinoDriver.DigitalValue.High));
            vxl3.ImageLocation = @"C:\Users\ahakille\Documents\visual studio 2017\Projects\Arduino1\Resources\2vänster.png";
        }

        private void vxl3f_Click(object sender, EventArgs e)
        {
            driver.Send(new DigitalWriteRequest(5, ArduinoDriver.DigitalValue.Low));

            vxl3.ImageLocation = @"C:\Users\ahakille\Documents\visual studio 2017\Projects\Arduino1\Resources\2raka.png";
        }

        private void vxl4t_Click(object sender, EventArgs e)
        {
            driver.Send(new DigitalWriteRequest(6, ArduinoDriver.DigitalValue.High));
            vxl4.ImageLocation = @"C:\Users\ahakille\Documents\visual studio 2017\Projects\Arduino1\Resources\2höger.png";
        }

        private void vxl4f_Click(object sender, EventArgs e)
        {
            driver.Send(new DigitalWriteRequest(6, ArduinoDriver.DigitalValue.Low));

            vxl4.ImageLocation = @"C:\Users\ahakille\Documents\visual studio 2017\Projects\Arduino1\Resources\2raka.png";
        }
    }
    
}
