package fr.gouv.finances.enfip;

public class JavaNiveau1 {

    /*
     * Écrivez une méthode estPair(int n) qui retourne true si le nombre est pair et
     * false sinon.
     */
    public boolean estPair(int n) {
        // TODO : Implémentez la logique ici
        return false; // Valeur temporaire
    }

    /*
     * Écrivez une méthode pourcentages(double prix, int pourcentages) qui retourne
     * le prix soldé après application d'une réduction en pourcentage.
     */
    public double pourcentages(double prix, int pourcentages) {
        // TODO : Implémentez la logique ici
        return 0.0; // Valeur temporaire
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
    public double tarif(int age, boolean salarier) {
        // Implémentez la logique de réduction ici
        return 0.0; // Valeur à remplacer
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
    public boolean estPremier(int nombre) {
        // Implémentez la logique ici avec une boucle for
        return false; // Valeur à remplacer
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
    public String identifiant(String nom, String prenom, int departement, int nombre) {
        // Compléter ici la logique pour générer l'identifiant
        return ""; // À remplacer par le code pour générer l'identifiant
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
    public int scoreMotDePasse(String motDePasse) {
        // Complétez cette méthode pour calculer le score
        return 0;
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
    public boolean mailValide(String mail) {
        // Complétez cette méthode
        return true;
    }

}
