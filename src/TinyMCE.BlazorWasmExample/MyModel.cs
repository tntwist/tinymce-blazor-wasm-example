using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TinyMCE.Blazor.Sample.BlazorWasm
{
    public class MyModel
    {
        [Required]
        public string Html { get; set; }
    }
}
