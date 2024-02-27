using System.Diagnostics;

namespace WinFormsDesignerModeTest_Core
{
    internal class Service
    {
        public event EventHandler DidSomething;
        public void DoSomething()
        {
            Debug.WriteLine("Service did something.");
            DidSomething?.Invoke(this, EventArgs.Empty);
        }
    }
}
