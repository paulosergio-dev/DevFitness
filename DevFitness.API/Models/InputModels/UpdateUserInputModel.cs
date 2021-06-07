using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Models.InputModels
{
    public class UpdateUserInputModel
    {
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
    }
}
