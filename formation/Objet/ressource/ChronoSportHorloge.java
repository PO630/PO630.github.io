// Classe enfant ChronoSportHorloge
public class ChronoSportHorloge extends Horloge 
{
    private int idPersonne;
    private String event;
    private String categorie;

    public ChronoSportHorloge(int heure, int minute, int seconde, String nom, int idPersonne, String event, String categorie) {
        super(heure, minute, seconde, nom); // Appel du constructeur de la superclasse
        this.idPersonne = idPersonne;
        this.event = event;
        this.categorie = categorie;
    }

    // Méthode pour obtenir les informations de la personne et de l'événement
    public String getSportInfo() {
        return String.format("ID Personne: %d, Événement: %s, Catégorie: %s", idPersonne, event, categorie);
    }

    @Override
    public String toString() {
        return String.format("ChronoSportHorloge de %s: %s, %s", nom, getFormattedTime(), getSportInfo());
    }
}