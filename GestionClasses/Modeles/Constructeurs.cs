using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasses.Modeles
{
    internal class Constructeurs
    {

        #region attributs 
        private inty _id;
        public static ObservableCollection<Constructeurs> CollClasse = new ObservableCollection<Constructeurs>();
        #endregion

        #region constructeur 
        public Constructeurs()
        {
           
            CollClasse.Add(this);
        }
        #endregion

        #region getter/setter 
        #endregion

        #region methodes 
        #endregion
    }
}
