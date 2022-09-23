namespace modulo3_semana04.PatternCommand
{
    public class DiscordCommand : ICommand
    {
        private string _mensagemDiscord = string.Empty;

        public DiscordCommand(string mensagemDiscord)
        {
            _mensagemDiscord = mensagemDiscord;
        }

        public string Execute()
        {
            return _mensagemDiscord;
        }
    }
}
