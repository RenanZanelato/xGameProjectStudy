using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xGame.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public string Message { get; private set; }

        public ResponseBase() 
        {
            Message = "Operacao Realizada com Sucesso";
        }
    }
}
