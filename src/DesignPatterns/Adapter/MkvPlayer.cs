namespace DesignPatterns.Adapter;
internal class MkvPlayer : IMediaPlayer
{
    public void Play(string fileName) =>
        Console.WriteLine($"Playing video {fileName}");
}
