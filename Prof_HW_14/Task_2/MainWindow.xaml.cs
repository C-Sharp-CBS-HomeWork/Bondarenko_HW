using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;


namespace Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isWork;
        CancellationTokenSource tokenSource;
        public MainWindow()
        {
            InitializeComponent(); 
            isWork = false;
            tokenSource = new CancellationTokenSource();
        }

        private async void btn_Connect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await OnConnectAsync(tokenSource.Token);
            }
            catch (Exception)
            {
                //Обработка ислючения
            }
            
        }

        private async void bnt_Cancel_Click(object sender, RoutedEventArgs e)
        {
            await OffConnectAsync();
        }
        private async Task OffConnectAsync() => await Task.Run(() => OffConnect());
        private void OffConnect()
        {
            if (isWork)
            {
                tokenSource.Cancel();
                isWork = false;
                Thread.Sleep(new Random().Next(2000, 5000));
                Dispatcher.Invoke(new Action(() => tb_Rez.Text += "\nОтключён от базы данных"));
            }     
        }
        private async Task OnConnectAsync(CancellationToken token) => await Task.Run(() => OnConnect(token));
        private void OnConnect(CancellationToken token)
        {
            isWork = true;
            Dispatcher.Invoke(new Action(() => tb_Rez.Text = "Подключён к базе данных"));
            while (isWork)
            {
                Thread.Sleep(new Random().Next(2000, 5000));
                if (token.IsCancellationRequested)
                    token.ThrowIfCancellationRequested(); 
                Dispatcher.Invoke(new Action(() => tb_Rez.Text += "\nДанные получены"));
            }     
        } 

    }
}
