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
            Structure S1 = new Structure("Test");
            Typage T1 = new Typage("int");
            Typage T2 = new Typage("string");
            Typage T3 = new Typage("Collection");
            Typage T4 = new Typage("Objet");
            Attributs A1  = new Attributs("s","_lesTypages",false,false,false,T3);
            Attributs A2 = new Attributs("s", "_leClient", false, false, false, T4);
            Attributs A3 = new Attributs("s", "id", false, false, false, T1);
            Attributs A4 = new Attributs("s", "Nom", false, false, false, T2);

            string res =S1.CreationStructure();
        }
    }
}
