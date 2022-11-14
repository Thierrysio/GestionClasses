using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasses.Modeles
{
    public abstract class Proprietes
    {

        #region attributs 
        private string _nom; 
        public static ObservableCollection<Proprietes> CollClasse = new ObservableCollection<Proprietes>();
        #endregion

        #region constructeur 
        public Proprietes(string nom)
        {
            _nom = nom;
            CollClasse.Add(this);
        }
        #endregion

        #region getter/setter 
        public string Nom{get => _nom; set => _nom = value; }
    #endregion

    #region methodes 
    #endregion
}
}
