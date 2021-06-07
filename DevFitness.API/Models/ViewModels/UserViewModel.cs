using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Models.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(int id, string fullName, decimal heigth, decimal weight, DateTime birthDate)
        {
            Id = id;
            FullName = fullName;
            Heigth = heigth;
            Weight = weight;
            BirthDate = birthDate;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public decimal Heigth { get; private set; }
        public decimal Weight { get; private set; }
        public DateTime BirthDate { get; private set; }
    }
}
