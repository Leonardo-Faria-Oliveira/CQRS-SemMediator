using Microsoft.AspNetCore.Mvc;
using SemMediator.Domain.Commands.Teste;
using SemMediator.Domain.Shared.Interfaces;
using SemMediator.Domain.Shared.Records;

namespace SemMediator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICommandHandler commandHandler;
 
        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICommandHandler _commandHandler)
        {
            commandHandler = _commandHandler;
        }

        [HttpPost]
        public Task<CommandResult> Post(TesteCommand command)
        {
            return commandHandler.Handle(command);
        }
    }
}
