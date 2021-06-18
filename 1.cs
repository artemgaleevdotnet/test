public async Task GetRealAsync(int id)
{
  Console.WriteLine(id);
  var d = await WebClient.DownloadStringAsync("https://ya.ru");
}

public async Task LetsGoRealAsync()
{
  var tasks = new List<Task>();
  for (int i = 0; i < 100; i++)
  {
    tasks.Add(GetRealAsync(i));
  }
  await Task.WhenAll(tasks);
}

//////////////////////////////////////////////

public async Task GetAsync(int id)
{
  await Task.Run(() => {
    Console.WriteLine(id);
    var d = WebClient.DownloadString("https://ya.ru");
  });
}

public async Task LetsGoAsync()
{
  var tasks = new List<Task>();
  for (int i = 0; i < 100; i++)
  {
    tasks.Add(GetAsync(i));
  }
  await Task.WhenAll(tasks);
}
