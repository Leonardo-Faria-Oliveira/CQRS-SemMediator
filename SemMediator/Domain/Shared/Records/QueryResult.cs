using SemMediator.Domain.Shared.Enums;
using SemMediator.Domain.Shared.Interfaces;
using System.Net;

namespace SemMediator.Domain.Shared.Records
{
    public record class QueryResult
    {
        public HttpStatusCode StatusCode;

        public string Message { get; set; } = string.Empty;

        public IViewModel? Data { get; set; }

        public int Rows { get; set; }

        public QueryResult()
        {
            this.Rows = 0;
            this.Data = null;
            this.Message = "NoResponse";
            this.StatusCode = HttpStatusCode.OK;
        }

        public QueryResult(EErrorResponse statusCode, string errorMessage)
        {
            this.Rows = 0;
            this.Data = null;
            this.Message = errorMessage;
            this.StatusCode = (HttpStatusCode)statusCode;
        }
    }
}
