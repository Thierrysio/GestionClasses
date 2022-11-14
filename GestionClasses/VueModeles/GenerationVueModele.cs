using GestionClasses.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasses.VueModeles
{
    internal class GenerationVueModele
    {
        public GenerationVueModele()
        {
            Attributs a  = new Attributs("s","_lesTypages",false,false,false,null);
            string res = a.GetAttributCollection();

        }
    }
}
