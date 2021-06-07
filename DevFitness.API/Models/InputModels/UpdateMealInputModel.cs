using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Models.InputModels
{
    public class UpdateMealInputModel
    {
        public string Description { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
    }
}
