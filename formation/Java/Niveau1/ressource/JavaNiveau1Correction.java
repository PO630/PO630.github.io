package fr.gouv.finances.enfip;

public class JavaNiveau1Correction extends JavaNiveau1 {

    /*
     * Écrivez une méthode estPair(int n) qui retourne true si le nombre est pair et
     * false sinon.
     */
    @Override
    public boolean estPair(int n) {
        return n % 2 == 0;
    }

    /*
     * Écrivez une méthode pourcentages(double prix, int pourcentages) qui retourne
     * le prix soldé après application d'une réduction en pourcentage.
     */
    @Override
    public double pourcentages(double prix, int pourcentages) {
        return prix * (1 - pourcentages / 100.0);
    }

    /*
     * Netflix propose un programme d'abonnement avec des réductions en fonction de
     * l'âge et du statut professionnel :
     * 
     * Les salariés bénéficient d'une réduction de 50% sur le prix de l'abonnement.
     * Les jeunes de moins de 25 ans et les personnes de plus de 60 ans bénéficient
     * d'une réduction de 20%. (non salariés)
     * Le prix de base de l'abonnement est de 20 euros.
     * Écrivez une méthode qui prend en entrée l'âge de l'utilisateur et un booléen
     * indiquant s'il est salarié. Elle doit retourner le prix de l'abonnement après
     * réduction.
     */
    @Override
    public double tarif(int age, boolean salarier) {
        double prix = 20.0;

        if (salarier) {
            prix *= 0.5; // Réduction de 50%
        } else if (age < 25 || age > 60) {
            prix *= 0.8; // Réduction de 20%
        }

        return prix;
    }

    /*
     * Un nombre premier est un entier naturel supérieur à 1 qui n'a que deux
     * diviseurs : 1 et lui-même.
     * Par exemple :
     * 
     * 2, 3, 5, 7, 11 sont des nombres premiers. ( attention 1 n'est pas premier )
     * 4, 6, 8, 9, 10 ne sont pas premiers car ils ont d'autres diviseurs que 1 et
     * eux-mêmes.
     * 
     * L'objectif de cet exercice est d'écrire une méthode qui vérifie si un nombre
     * donné est premier, en utilisant une boucle for.
     */
    @Override
    public boolean estPremier(int nombre) {
        if (nombre < 2) {
            return false; // Un nombre premier est strictement supérieur à 1
        }

        for (int i = 2; i < nombre; i++) { // Vérifie tous les diviseurs de 2 à nombre - 1
            if (nombre % i == 0) {
                return false; // Si un diviseur est trouvé, le nombre n'est pas premier
            }
        }

        return true; // Aucun diviseur trouvé, c'est un nombre premier
    }

    /*
     * Dans cet exercice, nous allons créer une méthode pour générer un identifiant
     * unique pour les abonnés de notre site.
     * Cet identifiant est composé du nom de l'utilisateur en majuscule, suivi de
     * son prénom en minuscule, puis du numéro de département suivi d'un underscore
     * (_) et enfin d'un nombre donné.
     * 
     * La méthode devra prendre en entrée les paramètres suivants :
     * 
     * nom (String) : le nom de l'utilisateur.
     * prenom (String) : le prénom de l'utilisateur.
     * departement (int) : le numéro de département.
     * nombre (int) : un nombre donné.
     */
    @Override
    public String identifiant(String nom, String prenom, int departement, int nombre) {
        // Conversion du nom en majuscule, du prénom en minuscule, ajout du département
        // et du nombre
        return nom.toUpperCase() + prenom.toLowerCase() + departement + "_" + nombre;
    }

    /*
     * Votre site web possède un validateur de mot de passe. Ce validateur retourne
     * la force d'un mot de passe en nombre de points en fonction de certains
     * paramètres.
     * 
     * Critères de validation :
     * 
     * Si le mot de passe contient une lettre majuscule, ajouter 1 point.
     * Si le mot de passe contient une lettre minuscule, ajouter 1 point.
     * Si le mot de passe contient un chiffre, ajouter 1 point.
     * Si le mot de passe contient un caractère spécial (comme ., ,, !, ?), ajouter
     * 1 point.
     * Si le mot de passe a une longueur supérieure à 14 caractères, ajouter 20
     * points.
     * Ajouter 1 point par caractère dans la chaîne.
     */
    @Override
    public int scoreMotDePasse(String motDePasse) {
        int score = 0;

        // Critère 1: Un point pour chaque caractère dans le mot de passe
        score += motDePasse.length();

        // Critère 2: Si le mot de passe contient une majuscule, +1
        if (motDePasse.matches(".*[A-Z].*")) {
            score += 1;
        }

        // Critère 3: Si le mot de passe contient une minuscule, +1
        if (motDePasse.matches(".*[a-z].*")) {
            score += 1;
        }

        // Critère 4: Si le mot de passe contient un chiffre, +1
        if (motDePasse.matches(".*[0-9].*")) {
            score += 1;
        }

        // Critère 5: Si le mot de passe contient un caractère spécial, +1
        if (motDePasse.matches(".*[.,!?].*")) {
            score += 1;
        }

        // Critère 6: Si le mot de passe fait plus de 14 caractères, ajouter 20 points
        if (motDePasse.length() > 14) {
            score += 20;
        }

        return score;
    }

    /*
     * Le site jetski-super-fan possède une page d'inscription. Un mail est
     * nécessaire pour l'inscription. Écrivez une méthode qui permet de savoir si un
     * mail est valide pour l'inscription.
     * 
     * Un mail est valide si :
     * 
     * Il possède exactement un "@".
     * La longueur de la partie avant le "@" et la partie après le "@" est
     * supérieure à 4.
     */
    @Override
    public boolean mailValide(String mail) {
        // Diviser le mail à l'index du "@"
        String[] parties = mail.split("@");

        // Vérifier qu'il y a exactement deux parties et que leur longueur est
        // supérieure à 4
        if (parties.length == 2 && parties[0].length() > 4 && parties[1].length() > 4) {
            return true; // Le mail est valide
        }
        return false; // Le mail est invalide
    }

}
