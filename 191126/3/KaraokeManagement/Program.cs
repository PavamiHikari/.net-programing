using KaraokeManagement.GUI;

namespace KaraokeManagement;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}