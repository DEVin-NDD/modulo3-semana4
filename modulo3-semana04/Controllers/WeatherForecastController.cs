using Microsoft.AspNetCore.Mvc;
using modulo3_semana04.PatternAdpter;
using modulo3_semana04.PatternCommand;
using modulo3_semana04.PattnerSingleton;

namespace modulo3_semana04.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpGet()]
        [Route("GetSingleton")]
        public string GetSingleton()
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();

            var codigoHash1 = singleton1.GetHashCode();
            var codigoHash2 = singleton2.GetHashCode();

            return $"codigoHash1 {codigoHash1} | codigoHash2 {codigoHash2} | {singleton1.DevolveHoraEmString()}";
        }

        [HttpGet()]
        [Route("GetAdpter")]
        public string GetAdpter()
        {
            AdapteNothingInterfaceLagacy adapteNothingInterfaceLagacy = new AdapteNothingInterfaceLagacy();
            ITarget target = new AdapterWithInterface(adapteNothingInterfaceLagacy);

            var returns = target.GetRequest();
            return returns;
        }

        [HttpGet()]
        [Route("GetCommand")]
        public string GetCommand()
        {
            Video video = new Video();

            ICommand discordCommand = new DiscordCommand("Video Audioslave  Musica Like a Stone");
            ICommand enviarVideoCommand = new EnviarVideoCommand(video, "https://www.youtube.com/watch?v=7QU1nvuxaMA");
            ICommand facebookCommand = new FacebookCommand();

            Invoker invoker = new Invoker(discordCommand, enviarVideoCommand, facebookCommand);
            return invoker.ExecutarRotinaDoCommand();
        }

    }
}