using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.ViewModel;

namespace WebApi1.Models
{
    public class Requests
    {       
        public string RequestString { get; set; }
        [Key]
        public DateTime Date { get; set; }
        public IEnumerable<Card> Cards { get; set; }

    }
}
