using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.TicketDispenser.Data.Models.Validation
{
    public interface IValidatable
    {
        bool IsValid();

        IEnumerable<ValidationError> GetErrors();
    }
}
