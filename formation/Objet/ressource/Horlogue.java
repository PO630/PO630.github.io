public class Horloge 
{
    public String nom;
    private int heure;
    private int minute;
    private int seconde;

    public Horloge(String nom, int heure, int minute, int seconde) {
        this.nom = nom;
        setTime(heure, minute, seconde);
    }

    public void setHeure(int heure) {
        if (heure >= 0) {
            this.heure = heure;
        } else {
            System.out.println("Heure invalide.");
        }
    }

    public void setMinute(int minute) {
        if (minute >= 0) {
            this.heure += minute / 60;          // Ajoute les heures supplémentaires si minute >= 60
            this.minute = minute % 60;           // Garde les minutes restantes (0-59)
            setHeure(this.heure);                // Mets à jour l'heure au cas où elle dépasserait 24
        } else {
            System.out.println("Minute invalide.");
        }
    }

    public void setSeconde(int seconde) {
        if (seconde >= 0) {
            this.minute += seconde / 60;         // Ajoute les minutes supplémentaires si seconde >= 60
            this.seconde = seconde % 60;         // Garde les secondes restantes (0-59)
            setMinute(this.minute);              // Mets à jour les minutes et potentiellement l'heure
        } else {
            System.out.println("Seconde invalide.");
        }
    }

    public void setTime(int heure, int minute, int seconde) {
        setHeure(heure);
        setMinute(minute);
        setSeconde(seconde);
    }

    public String afficherHeure() {
        return String.format("%02d:%02d:%02d", heure, minute, seconde);
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