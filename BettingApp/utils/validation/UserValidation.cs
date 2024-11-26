/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 18/11/2024
 * Heure: 19:04
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BettingApp.utils.validation
{
    public class UserValidation
    {
        public UserValidation() {}

        public bool ValidateCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Le code ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (code.Length > 10)
            {
                MessageBox.Show("Le code ne peut pas dépasser 10 caractères.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Le nom ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Regex regex = new Regex(@"^[A-Za-zÀ-ÖØ-öø-ÿ\s\-.']{3,50}$");
            if (!regex.IsMatch(lastName))
            {
                MessageBox.Show("Le nom doit contenir uniquement des lettres, des espaces, des tirets et des apostrophes et avoir au moins 3 caractères.", 
                              "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Le prénom ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Regex regex = new Regex(@"^[A-Za-zÀ-ÖØ-öø-ÿ\s\-.']{3,50}$");
            if (!regex.IsMatch(firstName))
            {
                MessageBox.Show("Le prénom doit contenir uniquement des lettres, des espaces, des tirets et des apostrophes et avoir au moins 3 caractères.", 
                              "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateGender(string gender)
        {
            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Le sexe ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (gender != "Masculin" && gender != "Feminin")
            {
                MessageBox.Show("Le sexe doit être 'Masculin' ou 'Feminin'.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateBirthDate(DateTime birthDate)
        {
            if (birthDate == DateTime.MinValue)
            {
                MessageBox.Show("La date de naissance ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-age)){
            	age--;
            }

            if (age < 18)
            {
                MessageBox.Show("Vous devez avoir au moins 18 ans.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (birthDate > DateTime.Now)
            {
                MessageBox.Show("La date de naissance ne peut pas être dans le futur.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidatePhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Le téléphone ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Regex regex = new Regex(@"^((3[1-46-9])|(4[0-46-9])|55|2[28])[0-9]{6}$");
            if (!regex.IsMatch(phone))
            {
                MessageBox.Show("Le numéro de téléphone doit correspondre à un numéro haïtien valide.", 
                              "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateNifCin(string nifCin)
        {
            if (string.IsNullOrWhiteSpace(nifCin))
            {
                MessageBox.Show("Le NIF/CIN ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            var ninuPattern = @"^\d{10}$";
            
            var nifPattern = @"^\d{3}-\d{3}-\d{3}-\d{1}$";

            if (!Regex.IsMatch(nifCin, ninuPattern) && !Regex.IsMatch(nifCin, nifPattern))
            {
                MessageBox.Show("Le NIF/CIN doit être soit un NINU de 10 chiffres, soit un NIF au format xxx-xxx-xxx-x", 
                              "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Le nom d'utilisateur ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Length > 50)
            {
                MessageBox.Show("Le nom d'utilisateur ne peut pas dépasser 50 caractères.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Le mot de passe ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("Le mot de passe doit avoir au moins 6 caractères.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateBalance(decimal balance)
        {
            if (balance < 0)
            {
                MessageBox.Show("Le solde ne peut pas être négatif.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateRole(string role)
        {
            if (role != "ADMIN" && role != "USER")
            {
                MessageBox.Show("Le rôle doit être 'ADMIN' ou 'USER'.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateStatus(string status)
        {
            if (status != "A" && status != "S" && status != "F")
            {
                MessageBox.Show("Le statut doit être 'A', 'S', ou 'F'.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}

