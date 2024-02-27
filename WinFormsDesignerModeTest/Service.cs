using System;
using System.Diagnostics;

namespace WinFormsDITest
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
