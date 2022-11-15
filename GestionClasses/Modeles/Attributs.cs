using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasses.Modeles
{
    internal class Attributs
    {
        #region attributs 
        private string _valeurParDefaut;
        private string _nom;
        private bool _visibiliteConstructeur;
        private bool _visibiliteGetter;
        private bool _visibiliteSetter;
        private Typage _leTypage;
        public static ObservableCollection<Attributs> CollClasse = new ObservableCollection<Attributs>();
        #endregion

        #region constructeur 
        public Attributs(string valeurParDefaut, string nom, bool visibiliteConstructeur, bool visibiliteGetter, bool visibiliteSetter, Typage leTypage)
        {
            _valeurParDefaut = valeurParDefaut;
            _nom = nom;
            _visibiliteConstructeur = visibiliteConstructeur;
            _visibiliteGetter = visibiliteGetter;
            _visibiliteSetter = visibiliteSetter;

            CollClasse.Add(this);
            _leTypage = leTypage;
        }
        #endregion

        #region getter/setter 
        public string ValeurParDefaut { get => _valeurParDefaut; set => _valeurParDefaut = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public bool VisibiliteConstructeur { get => _visibiliteConstructeur; set => _visibiliteConstructeur = value; }
        public bool VisibiliteGetter { get => _visibiliteGetter; set => _visibiliteGetter = value; }
        public bool VisibiliteSetter { get => _visibiliteSetter; set => _visibiliteSetter = value; }
        internal Typage LeTypage { get => _leTypage; set => _leTypage = value; }
        #endregion

        #region methodes 
        public string GetLignePrivate()
        {
            if (this.Nom.Contains("_les")) return this.GetAttributCollection();
            if (this.Nom.Contains("_le")) return this.GetAttributObjet();
            return "private " + this.LeTypage.Nom + " " +this.GetVerificationNomUnderscore() + "; \r\n";
        }
        private string GetVerificationNomUnderscore()
        {
            string resultat = this.Nom;

            if (resultat[0].ToString() != "_") resultat =  resultat.Insert(0, "_");
            
            return resultat;
        }

        public string SetLowerCararactere2()
        {
            string resultat = null;
            resultat = this.GetVerificationNomUnderscore();
            resultat = resultat.Replace("_"+resultat[1].ToString(), resultat[1].ToString().ToLower());
            return resultat;
        }
        public string SetUpperCararactere2()
        {
            string resultat = null;
            resultat = resultat.Replace(resultat[1].ToString(), resultat[1].ToString().ToUpper());
            return resultat;
        }

        public string SetLowerNomSansUnderscore()
        {
            string resultat = this.GetVerificationNomUnderscore();
            return resultat;
        }
       
        private string GetAttributObjet()
        {
            string resultat = null;
            if (this.Nom.Contains("_le"))
            {
              resultat = "private " + this.Nom.Remove(0,3) + "  " + this.Nom + ";\r\n";
              this.LeTypage = new Typage(this.Nom.Remove(0, 3));
            }
            return resultat;
        }
        public string GetAttributCollection()
        {
            string resultat = null;
            if (this.Nom.Contains("_les"))
            {
                resultat = "private " +this.collection() + " " + this.Nom + ";\r\n";
            }
            return resultat;
        }

        public string collection()
        {
            return "List <" + this.Nom.Remove(0, 4) + "> ";
        }
        #endregion
    }
}
