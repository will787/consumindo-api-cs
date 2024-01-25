using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Dtos
{
    public class ResponseGenerico<T> where T: class
    {
        public HttpStatusCode CodigoHttp { get; set;}
        public T? DadosRetorno { get; set;}
        public ExpandoObject? ErroRetorno { get;  set; } // em tempo de execução ele recebe o objeto, quando no caso tiver um erro, retorna conforme a API
    }
}