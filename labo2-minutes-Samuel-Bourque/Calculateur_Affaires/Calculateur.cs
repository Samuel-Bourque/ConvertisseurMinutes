using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur_Affaires
{
    public class Calculateur
    {
        public double calculerMinutes(int nbSecondes) {
            return (double) nbSecondes / 60;
        }
    }
}
