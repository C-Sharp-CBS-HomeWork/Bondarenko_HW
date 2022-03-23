using Task_2.Entity;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                using var db = new CursesDBContext();

                var curses = db.Curse.ToList();

                foreach (var curse in curses)
                    DGBResult.Rows.Add(curse.Id, curse._Curse, curse.Count);
            });
        }
    }
}