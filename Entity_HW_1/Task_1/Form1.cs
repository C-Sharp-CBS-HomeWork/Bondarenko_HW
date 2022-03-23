using Task_1.Entity;

namespace Task_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private async void ConnectToBD_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                using var DB = new MyDatabaseContext();
                var users = DB.MyTable.ToList();

                foreach (var user in users)
                    DGVResult.Rows.Add(user.Id, user.Name, user.Age);
            });
        }
    }
}