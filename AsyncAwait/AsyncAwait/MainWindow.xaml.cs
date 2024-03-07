using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            //  TimeConsumingMethod();
            //TimeConsumingMethodAsync(); // This is an async method, so it will not block the UI thread

            //DownloadHtml("http://msdn.microsoft.com", "c:/Users/rubayat/msdn.html"); // While the download is in progress,
            //the UI is blocked, meaning
            //we cannot move the window or resize it.

            DownloadHtmlAsync("http://msdn.microsoft.com", "c:/Users/rubayat/msdn.html");       
        
        }

        private async void btnStart_ClickAsync(object sender, RoutedEventArgs e)  //This is an async event handler
        {
            var getHtmlTask = GetHtmlAsync("http://msdn.microsoft.com"); 
            MessageBox.Show("Waiting for the task to complete"); //This message will be shown immediately

            var html = await getHtmlTask;             //This line will be executed after the task is completed
            MessageBox.Show(html.Substring(0, 10));
        }

        


        public void TimeConsumingMethod()
        {
            // Simulate a long running process
            System.Threading.Thread.Sleep(5000);
        }

        public async Task TimeConsumingMethodAsync()
        {
            // Simulate a long running process
            await Task.Delay(5000);
        }

       

        public async Task DownloadHtmlAsync(string url, string fileName)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url); //DownloadStringTaskAsync is an async method
                                                                     // As soon as the complier sees the await keyword,
                                                                     //it returns the control to the caller and when the 
                                                                     //download is complete, it comes back to the method
            
            
            using (var streamWriter = new StreamWriter(fileName))     
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public void DownloadHtml(string url, string fileName)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(fileName))
            {
                streamWriter.Write(html);
            }
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
