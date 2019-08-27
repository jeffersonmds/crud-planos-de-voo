namespace Saipher.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Message = "Operação realizada com sucesso";
        }

        public string Message { get; set; }
    }
}
