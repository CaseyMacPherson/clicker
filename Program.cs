using System.Diagnostics;
using clicker;

var application = Process.GetProcessesByName("RealmGrinderDesktop").FirstOrDefault();

if (application != null)
{
    UIWindowsOperations.SetForegroundWindow(application.MainWindowHandle);
    UIWindowsOperations.GetWindowRect(application.MainWindowHandle, out var windowDimensions);
    
    var horizontalCenter = windowDimensions.Left + ((windowDimensions.Right - windowDimensions.Left) / 2);
    var verticalCenter = windowDimensions.Bottom - ((windowDimensions.Bottom - windowDimensions.Top) / 2);
    
    MouseOperations.SetCursorPosition(horizontalCenter,verticalCenter);

    for (var i = 0; i < 10000; i++)
    {
        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
        Thread.Sleep(10);
        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
        Thread.Sleep(10);
    }

}

