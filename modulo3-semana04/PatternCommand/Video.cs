namespace modulo3_semana04.PatternCommand
{
    public class Video
    {
        public string Play(string urlVideo)
        {
            return $"Opcao Play {urlVideo}";
        }

        public string Stop()
        {
            return $"Opcao Stop";
        }

        public string Back()
        {
            return $"Opcao Back";
        }
    }
}
