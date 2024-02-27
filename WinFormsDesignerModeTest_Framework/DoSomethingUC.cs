using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsDITest
{
    public partial class DoSomethingUC : UserControl
    {
        #region designer helper code
        /// <summary>
        /// Tells whether the current execution environment is WinForms designer or regular WinForms process.
        /// This is required for UserControls to ensure that code in OnLoad handler or in constructor which has outside dependencies is not executed by WinForms designer where it crashes because dependencies are not available.
        /// <br><see cref="LicenseManager.UsageMode"/> is better than <see cref="Component.DesignMode"/> 
        /// because <see cref="Component.DesignMode"/> does not work in constructor</br>
        /// </summary>
        protected readonly bool designMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        #endregion

        private readonly Service service;
        public DoSomethingUC()
        {
            InitializeComponent();
            service = DIContainer.Get<Service>();
            if (designMode == false)
            {
                //throw new InvalidOperationException($"Designer entered code which was not supposed to be entered in design mode and UsageMode was {LicenseManager.UsageMode}!");
                service.DidSomething += Service_DidSomething;
            }
        }

        private void Service_DidSomething(object sender, EventArgs e)
        {
            MessageBox.Show("Service did something.");
        }

        private void button_Click(object sender, EventArgs e)
        {
            service.DoSomething();
        }
    }
}
