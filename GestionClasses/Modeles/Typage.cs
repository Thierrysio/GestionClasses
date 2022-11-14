using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasses.Modeles
{
    internal class Typage
    {

        #region attributs 
        private string _nom;
        public static ObservableCollection<Typage> CollClasse = new ObservableCollection<Typage>();
        #endregion

        #region constructeur 
        public Typage(string nom)
        {
            _nom = nom;
            CollClasse.Add(this);
        }
        #endregion

        #region getter/setter 
        public string Nom { get => _nom; set => _nom = value; }
        #endregion

        #region methodes 
        #endregion
    }
}
