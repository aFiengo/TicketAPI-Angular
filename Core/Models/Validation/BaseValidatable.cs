﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models.Validation;

namespace Truextend.TicketDispenser.Core.Models.Validation
{
    public abstract class BaseValidatable : IValidatable
    {
        protected IEnumerable<ValidationError> Errors;

        protected BaseValidatable()
        {
            Errors = new List<ValidationError>();
        }

        public abstract bool IsValid();

        protected void AddError(ValidationError error)
        {
            ((List<ValidationError>)Errors).Add(error);
        }

        public IEnumerable<ValidationError> GetErrors()
        {
            return Errors;
        }
    }
}
