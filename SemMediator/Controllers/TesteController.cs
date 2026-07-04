using Microsoft.AspNetCore.Mvc;
using SemMediator.Domain.Commands.Teste;
using SemMediator.Domain.Queries.Teste;
using SemMediator.Domain.Shared.Interfaces;
using SemMediator.Domain.Shared.Records;

namespace SemMediator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly ICommandHandler commandHandler;
        private readonly IQueryHandler queryHandler;
 
        public TesteController(
            ICommandHandler _commandHandler,
            IQueryHandler _queryHandler)
        {
            commandHandler = _commandHandler;
            queryHandler = _queryHandler;
        }

        [HttpPost]
        public Task<CommandResult> Post(TesteCommand command)
        {
            return commandHandler.Handle(command);
        }

        [HttpGet]
        public Task<QueryResult> List(ListTestsQuery query)
        {
            return queryHandler.Query(query);
        }
    }
}
