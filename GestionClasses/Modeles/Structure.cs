using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasses.Modeles
{
    internal class Structure
    {
        #region attributs 
        private string _nom;
        private List<Proprietes> _lesProprietes;
        private List<Attributs> _lesAttributs;
        private List<Constructeurs> _lesConstructeurs;
        private List<Methodes> _lesMethodes;
        public static ObservableCollection<Structure> CollClasse = new ObservableCollection<Structure>();
        #endregion

        #region constructeur 
        public Structure(string nom)
        {
            _nom = nom;
            _lesProprietes = new List<Proprietes>();
            _lesAttributs = new List<Attributs>();
            _lesConstructeurs = new List<Constructeurs>();
            _lesMethodes = new List<Methodes>();
            CollClasse.Add(this);
        }
        #endregion

        #region getter/setter 
        public string Nom { get => _nom; set => _nom = value; }
        public List<Proprietes> LesProprietes { get => _lesProprietes; set => _lesProprietes = value; }
        public List<Attributs> LesAttributs { get => _lesAttributs; set => _lesAttributs = value; }
        public List<Constructeurs> LesConstructeurs { get => _lesConstructeurs; set => _lesConstructeurs = value; }
        public List<Methodes> LesMethodes { get => _lesMethodes; set => _lesMethodes = value; }
        #endregion

        #region methodes 

        public string CreationStructure()
        {
            string resultat = null;
            resultat += this.GetUsing();
            resultat += this.GetClasse();
            resultat += this.GetAttributs();
            resultat += this.GetConstructeurs();
            resultat += this.GetProprietes(); 
            resultat += this.GetMethodes();
            return resultat;
        }

        private string GetUsing()
        {
            string resultat =
            "using System;\r\n" +
                "using System.Collections.Generic; \r\n" +
                "using System.Linq;\r\n" +
                "using System.Text;\r\n" +
                "using System.Threading.Tasks \r\n\r\n";
                
            return resultat;
        }
        private string GetClasse()
        {
          return  "public class " + this.Nom + "\r\n";
        }
        public string GetAttributs()
        {
            string resultat = null;
            resultat = "{ \r\n#region attributs \r\n";

            foreach (Attributs monAttribut in Attributs.CollClasse)
            {
                resultat += monAttribut.GetLignePrivate();
            }
            resultat += this.GetCollectionClasse();
            return resultat;
        }

        private string GetCollectionClasse()
        {
            return "public static ObservableCollection<" + this.Nom + "> CollCLasse = new ObservableCollection<" + this.Nom + ">(); \n" +
                "#endregion \r\n";
        }
        private string GetConstructeurs()
        {
            this.LesConstructeurs.Add(new Constructeurs(this));
            string resultat = this.LesConstructeurs[0].GetSignature();

            resultat += this.LesConstructeurs[0].GetBody();
            return resultat;
        }
        private string GetProprietes()
        {
            string resultat = null;
            return resultat;
        }
        private string GetMethodes()
        {
            string resultat = null;
            return resultat;
        }
        #endregion
    }
}
