namespace DesignPatterns.Adapter;
internal class MediaAdapter
{
    readonly IMediaPlayer _player;

    public MediaAdapter(string fileType)
    {
        _player = fileType switch
        {
            "mkv" => new MkvPlayer(),
            "mp3" => new Mp3Player(),
            _ => throw new ArgumentException("File type is not supported"),
        };
    }

    public void Play(string fileName)
    {
        if (_player is not null)
            _player.Play(fileName);
    }
}
