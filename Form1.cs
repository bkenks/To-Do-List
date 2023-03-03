using System.Runtime.InteropServices;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnToDo.Height;
            pnlNav.Top = btnToDo.Top;
            pnlNav.Left = btnToDo.Left;
            btnToDo.BackColor = Color.FromArgb(46, 51, 73);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            // Highlight button when clicked
            pnlNav.Height = btnToDo.Height;
            pnlNav.Top = btnToDo.Top;
            pnlNav.Left = btnToDo.Left;
            btnToDo.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}