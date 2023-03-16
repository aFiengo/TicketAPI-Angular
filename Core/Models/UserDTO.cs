using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models.Validation;
using Truextend.TicketDispenser.Data.Models.Validation;

namespace Truextend.TicketDispenser.Core.Models
{
    public class UserDTO 
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int CellphoneNumber { get; set; }

        private int CalculateAge(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;
            if (birthday > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
