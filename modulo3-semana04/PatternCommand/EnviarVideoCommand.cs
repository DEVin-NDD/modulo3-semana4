namespace modulo3_semana04.PatternCommand
{
    public class EnviarVideoCommand : ICommand
    {
        private readonly Video video;
        private readonly string urlVideo;

        public EnviarVideoCommand(Video video, string urlVideo)
        {
            this.video = video;
            this.urlVideo = urlVideo;
        }

        public string Execute()
        {
            string returnsPlay = video.Play(urlVideo);
            string returnsStop = video.Stop();
            string returnsBack = video.Back();

            return $"EnviarVideoCommand - {returnsPlay} - {returnsStop} - {returnsBack}";
        }
    }
}
