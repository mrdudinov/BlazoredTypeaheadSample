using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoredTypeaheadSample.Data
{
    public class FormExample
    {
        [Required]
        public Person SelectedPerson { get; set; }
    }
}
