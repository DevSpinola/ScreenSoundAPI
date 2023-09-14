using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resp = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");       
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resp)!;
        musicas[0].ExibirDetalhesDaMusica();
    }
    catch  (Exception ex)
    {
        Console.WriteLine($"Temos um problema:{ex.Message} ");
    }
   
}    