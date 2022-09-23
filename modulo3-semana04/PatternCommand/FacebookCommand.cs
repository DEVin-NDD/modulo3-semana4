namespace modulo3_semana04.PatternCommand
{
    public class FacebookCommand : ICommand
    {
        public string Execute()
        {
            return $"Mensagem Curtida no facebook";
        }
    }
}
