namespace DesignPatterns.Adapter;
internal class ExampleClass
{
    protected void Method()
    {
        var audioPlayer = new MediaAdapter("mp3");
        var videoPlayer = new MediaAdapter("mkv");

        audioPlayer.Play("aaa.mp3");
        videoPlayer.Play("bbb.mkv");
    }
}
