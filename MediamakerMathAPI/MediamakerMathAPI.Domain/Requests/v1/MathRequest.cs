using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediamakerMathAPI.Domain.Requests.v1
{
    public class MathRequest
    {
        [Required]
        public float? ItemA { get; set; }

        [Required]
        public float? ItemB { get; set; }
    }
}
