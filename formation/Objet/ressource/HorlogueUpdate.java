public class Horloge 
{
    
    private int secondes; // On stocke tout en secondes maintenant
    public String nom;

    public Horloge(int heure, int minute, int seconde, String nom) {
        this.nom = nom;
        setHeure(heure);
        setMinute(minute);
        setSeconde(seconde);
    }

    // Ajuste les heures en secondes
    public void setHeure(int heure) {
        this.secondes += heure * 3600;
    }

    // Ajuste les minutes en secondes
    public void setMinute(int minute) {
        this.secondes += minute * 60;
    }

    // Ajuste les secondes directement
    public void setSeconde(int seconde) {
        this.secondes += seconde;
    }

    // Récupère l'heure au format HH:MM:SS
    public String afficherHeure() {
        int heures = secondes / 3600;
        int minutes = (secondes % 3600) / 60;
        int sec = secondes % 60;
        return String.format("%02d:%02d:%02d", heures, minutes, sec);
    }
}



public static void main(String[] args) 
{
        Horloge horloge = new Horloge("Horloge de Bureau", 10, 59, 50);
        System.out.println(horloge.nom + " : " + horloge.afficherHeure()); // Affiche : "Horloge de Bureau : 10:59:50"

        // Utilisation des méthodes
        horloge.setHeure(23);
        System.out.println("Après setHeure(23): " + horloge.afficherHeure()); 

        horloge.setMinute(65);
        System.out.println("Après setMinute(65): " + horloge.afficherHeure()); 

        horloge.setSeconde(3665);
        System.out.println("Après setSeconde(3665): " + horloge.afficherHeure()); 

        horloge.setTime(5, 10, 30);
        System.out.println("Après setTime(5, 10, 30): " + horloge.afficherHeure()); 
    
}