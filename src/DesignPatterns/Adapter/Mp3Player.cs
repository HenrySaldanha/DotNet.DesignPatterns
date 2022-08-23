namespace DesignPatterns.Adapter;
internal class Mp3Player : IMediaPlayer
{
    public void Play(string fileName) =>
        Console.WriteLine($"Playing music {fileName}");
}
