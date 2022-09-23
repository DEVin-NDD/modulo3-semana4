namespace modulo3_semana04.PatternCommand
{
    public class Invoker
    {
        private readonly ICommand discordCommand;
        private readonly ICommand videoCommand;
        private readonly ICommand facebookCommand;

        public Invoker(ICommand discordCommand, ICommand videoCommand, ICommand facebookCommand)
        {
            this.discordCommand = discordCommand;
            this.videoCommand = videoCommand;
            this.facebookCommand = facebookCommand;
        }

        public string ExecutarRotinaDoCommand()
        {
            string returnsDiscordString = discordCommand.Execute();
            string returnsVideoString = videoCommand.Execute();
            string returnsFacebookString = facebookCommand.Execute();

            return $"{returnsDiscordString} - {returnsVideoString} - {returnsFacebookString}";
        }
    }
}
