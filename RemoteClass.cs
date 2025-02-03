using System;
using System.Windows.Forms; // Add this if you need MessageBox.Show()

namespace RemoteNamespace // 🔹 Ensure it has a namespace
{
    public class RemoteClass
    {
        public string GetMessage()
        {
            return "Hello from the cloud!";
        }

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
