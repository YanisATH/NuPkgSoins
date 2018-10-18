// <copyright file="Intervenant.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassesMetier
{
    using System.Collections.ObjectModel;

    public class Intervenant
    {
        private Collection<Prestation> lesPrestations;
        private string nom;
        private string prenom;


        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.lesPrestations = new Collection<Prestation>();
        }

        public Collection<Prestation> LesPrestations
        {
          get { return this.lesPrestations; }
          set { this.lesPrestations = value; }
        }

        public string Nom { get => nom; set => nom = value; }

        public string Prenom { get => prenom; set => prenom = value; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Intervenant : " + this.Nom + " - " + this.Prenom;
        }

        public virtual string AfficheIntervenantComplet()
        {
            return this.ToString() + this.SesInterventions();
        }

        ///////
        public void AjoutePrestation(Prestation prestation)
        {
            this.lesPrestations.Add(prestation);
        }

        protected string SesInterventions()
        {
            string chaine = " ";
            foreach (Prestation unePrestation in this.lesPrestations)
            {
                chaine += "\n\t" + unePrestation;
            }

            return chaine;
        }
    }
}
