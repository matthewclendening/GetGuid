using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GetGuid.Properties;

namespace GetGuid
{
    internal sealed class GetGuidController : IDisposable
    {
        private readonly ApplicationContext _appContext;
        private IContainer _components;
        private NotifyIcon _notifyIcon;
        private GuidFormatDlg _guidFormatDlg;
        private string _guidFormat = "B";
        private bool _disposed;

        public GetGuidController(ApplicationContext context)
        {
            _appContext = context;
            Initialize();
        }

        private void Initialize()
        {
            _components = new Container();
            _notifyIcon = new NotifyIcon(_components);
            var notifyIconContextMenu = new ContextMenu();
            var showContextMenuItem = new MenuItem();
            var aboutContextMenuItem = new MenuItem();
            var exitContextMenuItem = new MenuItem();

            _notifyIcon.ContextMenu = notifyIconContextMenu;
            _notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            _notifyIcon.Click += notifyIcon_Click;
            _notifyIcon.Icon = new Icon(typeof (CustomApplicationContext), "getguidtray.ico");
            _notifyIcon.Text = Resources.Click_to_generate_text;
            _notifyIcon.Visible = true;

            notifyIconContextMenu.MenuItems.AddRange(
                new[] {showContextMenuItem, aboutContextMenuItem, exitContextMenuItem});

            showContextMenuItem.Index = 0;
            showContextMenuItem.Text = Resources.Menu_Options_Text;
            showContextMenuItem.DefaultItem = true;
            showContextMenuItem.Click += showContextMenuItem_Click;

            aboutContextMenuItem.Index = 1;
            aboutContextMenuItem.Text = Resources.Menu_About_Text;
            aboutContextMenuItem.Click += aboutContextMenuItem_Click;

            exitContextMenuItem.Index = 2;
            exitContextMenuItem.Text = Resources.Menu_Exit_Text;
            exitContextMenuItem.Click += exitContextMenuItem_Click;
        }

        private void ShowForm()
        {
            if (_guidFormatDlg == null)
            {
                _guidFormatDlg = new GuidFormatDlg(_guidFormat);
                _guidFormatDlg.Show();

                _guidFormatDlg.FormClosed += GuidFormatDlgFormClosed;
            }
            else
            {
                _guidFormatDlg.Activate();
            }
        }
        
        private void exitContextMenuItem_Click(object sender, EventArgs e)
        {
            _appContext.ExitThread();
        }

        private void aboutContextMenuItem_Click(object sender, EventArgs e)
        {
            _notifyIcon.ShowBalloonTip(5000, "About GetGuid",
                "GUID Generator by Matthew Clendening", ToolTipIcon.Info);
        }

        private void showContextMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            Clipboard.SetText(guid.ToString(_guidFormat).ToUpper());
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void GuidFormatDlgFormClosed(object sender, FormClosedEventArgs e)
        {
            _guidFormat = _guidFormatDlg.GuidFormat;
            _guidFormatDlg = null;
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }
            if (_components != null)
            {
                _components.Dispose();
            }
            _disposed = true;
        }

        #endregion
    }
}
