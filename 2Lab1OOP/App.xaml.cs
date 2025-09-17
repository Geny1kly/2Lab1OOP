using System.Configuration;
using System.Data;
using System.Net.Http;
using System.Text.Json;
using System.Windows;

namespace _2Lab1OOP;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private async void App_OnStartup(object sender, StartupEventArgs e)
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36");
        var request = new HttpRequestMessage(HttpMethod.Get, "https://yande.re/post.json?tags=s+landscape&limit=100");
        var response = await client.SendAsync(request);
        var json = await response.Content.ReadAsStringAsync();
        var posts = JsonSerializer.Deserialize<List<Post>>(json)!;

        var strUrl = posts[Random.Shared.Next(0, posts.Count)].jpeg_url;
        Console.WriteLine(strUrl);
        
        var mainWindow = new MainWindow(new Uri(strUrl));
        mainWindow.Show();
    }
}