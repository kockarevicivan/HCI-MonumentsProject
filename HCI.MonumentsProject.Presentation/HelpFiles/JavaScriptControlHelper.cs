using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows;

namespace HCI.MonumentsProject.Presentation.HelpFiles
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class JavaScriptControlHelper
    {
        Window prozor;
        public JavaScriptControlHelper(Window w)
        {
            prozor = w;
        }

    }
}
