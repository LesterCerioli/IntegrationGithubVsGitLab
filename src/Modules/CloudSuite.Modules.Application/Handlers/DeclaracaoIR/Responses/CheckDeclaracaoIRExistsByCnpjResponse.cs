﻿using CloudSuite.Modules.Application.Core;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Modules.Application.Handlers.DeclaracaoIR.Responses
{
    public class CheckDeclaracaoIRExistsByCnpjResponse : Response
    {
        public Guid RequestId { get; private set; }
        public bool Exists { get; set; }


        public CheckDeclaracaoIRExistsByCnpjResponse(Guid requestId, bool exists, ValidationResult result)
        {
            RequestId = requestId;
            Exists = exists;
            foreach (var item in result.Errors)
            {
                this.AddError(item.ErrorMessage);
            }
        }

        public CheckDeclaracaoIRExistsByCnpjResponse(Guid requestId, string falseValidation)
        {
            RequestId = requestId;
            Exists = false;
            this.AddError(falseValidation);
        }
    }
}
