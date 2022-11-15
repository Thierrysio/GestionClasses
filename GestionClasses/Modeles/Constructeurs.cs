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
        private int _id;
        private Structure _laStructure;
        public static ObservableCollection<Constructeurs> CollClasse = new ObservableCollection<Constructeurs>();

        #endregion

        #region constructeur 
        public Constructeurs(Structure laStructure)
        {

            CollClasse.Add(this);
            _laStructure = laStructure;
        }
        #endregion

        #region getter/setter 
        public Structure LaStructure { get => _laStructure; set => _laStructure = value; }

        #endregion

        #region methodes 
        public string GetSignature()
        {
            string resultat = "\r\n#region constructeurs\r\npublic " + this.LaStructure.Nom + "(";

            foreach (Attributs monAttribut in Attributs.CollClasse)
            {
            if(!monAttribut.Nom.Contains("_les"))    resultat += monAttribut.LeTypage.Nom + " " + monAttribut.SetLowerCararactere2() + ",";
            }
            resultat = resultat.Substring(0, resultat.Length - 1);
            resultat += ")\r\n";
            return resultat;
        }

        public string GetBody()
        {
            string resultat = "{\r\n ";
            foreach (Attributs monAttribut in Attributs.CollClasse)
            {
                if (!monAttribut.Nom.Contains("_les"))
                {
                    resultat += monAttribut.SetLowerNomSansUnderscore() + " = " + monAttribut.SetLowerCararactere2() + "; \n";
                }
                else
                {
                    resultat += monAttribut.SetLowerNomSansUnderscore() + " = new " +monAttribut.collection() + "();\r\n";
                }
            }
            resultat += "CollClasse.Add(this); \r\n";
            resultat += "} \n #endregion \r\n \n";
            
            return resultat;
        }
        #endregion
    }
}
