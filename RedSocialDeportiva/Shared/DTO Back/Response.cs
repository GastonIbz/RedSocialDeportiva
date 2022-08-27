using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialDeportiva.Shared.DTO_Back
{
     public class Response
    {
        public class ResponseDto<TypeData>
        {
            public TypeData Data { get; set; } //Informacion
          
            public string MessageError { get; set; }
        }
    }
}
