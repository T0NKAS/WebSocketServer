using Microsoft.AspNetCore.SignalR.Client;
using System.Collections.ObjectModel;

namespace WebSocketClient
{
    public partial class MainPage : ContentPage
    {
        private HubConnection _hubConnection;
        private ObservableCollection<string> _messages;

        public MainPage()
        {
            InitializeComponent();

            _messages = new ObservableCollection<string>();
            MessagesListView.ItemsSource = _messages;

            _hubConnection = new HubConnectionBuilder()
                .WithUrl("https://yourserver.com/chatHub")
                .Build();

            _hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                var formattedMessage = $"{user}: {message}";
                _messages.Add(formattedMessage);
            });

            ConnectToServer();
        }

        private async void ConnectToServer()
        {
            try
            {
                await _hubConnection.StartAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Could not connect to server: {ex.Message}", "OK");
            }
        }

        private async void OnSendButtonClicked(object sender, EventArgs e)
        {
            var user = UserEntry.Text;
            var message = MessageEditor.Text;

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(message))
            {
                await _hubConnection.InvokeAsync("SendMessage", user, message);
            }
        }
    }
}