class ChronoSportHorloge(Horloge):
    def __init__(self, heure, minute, seconde, nom, id_personne, event, categorie):
        super().__init__(heure, minute, seconde, nom)  # Appel du constructeur de la superclasse
        self.id_personne = id_personne
        self.event = event
        self.categorie = categorie

    # Méthode pour obtenir les informations de la personne et de l'événement
    def get_sport_info(self):
        return f"ID Personne: {self.id_personne}, Événement: {self.event}, Catégorie: {self.categorie}"

    def __str__(self):
        return f"ChronoSportHorloge de {self.nom}: {self.get_formatted_time()}, {self.get_sport_info()}"
