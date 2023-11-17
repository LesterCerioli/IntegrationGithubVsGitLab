﻿using CloudSuite.Modules.Application.Handlers.Note.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountryEntity = CloudSuite.Modules.Domain.Models.Country;
using StateEntity = CloudSuite.Modules.Domain.Models.State;

namespace CloudSuite.Modules.Application.Handlers.State
{
    public class CreateStateCommand : IRequest<CreateNoteResponse>
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [StringLength(100)]
        public string? StateName { get; private set; }

        [Required(ErrorMessage = "Este cmapo é de preenchimento obrigatório.")]

        public string? UF { get; private set; }

        public CountryEntity Country { get; private set; }

        public Guid CountryId { get; private set; }


        public StateEntity GetEntity() 
        {
            return new StateEntity(
                this.Id = Guid.NewGuid(),
                this.UF,
                this.StateName,
                this.CountryId
                );
        }
    }
}
