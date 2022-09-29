using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediamakerMathAPI.Domain.Enumerations
{
    public enum MathFailure
    {
        [Description("The provided body is invalid")]
        BodyInvalid
    }
}
