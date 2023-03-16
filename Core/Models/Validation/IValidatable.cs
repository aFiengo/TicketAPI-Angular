using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models.Validation;

namespace Truextend.TicketDispenser.Core.Models.Validation
{
    public interface IValidatable
    {
        bool IsValid();
        IEnumerable<ValidationError> GetErrors();
    }
}
