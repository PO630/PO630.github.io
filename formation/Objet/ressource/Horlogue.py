

class Horloge:
    def __init__(self, nom, heure=0, minute=0, seconde=0):
        self.nom = nom
        self.set_time(heure, minute, seconde)

    def set_heure(self, heure):
        if heure >= 0:
            self.heure = heure
        else:
            print("Heure invalide.")

    def set_minute(self, minute):
        if minute >= 0:
            self.heure += minute // 60          # Ajoute les heures supplémentaires si minute >= 60
            self.minute = minute % 60           # Garde les minutes restantes (0-59)
            self.set_heure(self.heure)          # Mets à jour l'heure si nécessaire
        else:
            print("Minute invalide.")

    def set_seconde(self, seconde):
        if seconde >= 0:
            self.minute += seconde // 60        # Ajoute les minutes supplémentaires si seconde >= 60
            self.seconde = seconde % 60         # Garde les secondes restantes (0-59)
            self.set_minute(self.minute)        # Mets à jour les minutes et potentiellement l'heure
        else:
            print("Seconde invalide.")

    def set_time(self, heure, minute, seconde):
        self.set_heure(heure)
        self.set_minute(minute)
        self.set_seconde(seconde)

    def afficher_heure(self):
        return f"{self.heure:02d}:{self.minute:02d}:{self.seconde:02d}"


# Exemple d'utilisation
horloge = Horloge("Horloge Murale", 14, 70, 3665)
print(f"{horloge.nom} : {horloge.afficher_heure()}")  # Affiche : "Horloge Murale : 16:12:05"

# Utilisation des méthodes
horloge.set_heure(23)
print(f"Après set_heure(23): {horloge.afficher_heure()}")  # Affiche : "23:59:50"

horloge.set_minute(65)
print(f"Après set_minute(65): {horloge.afficher_heure()}")  # Affiche : "00:05:50"

horloge.set_seconde(3665)
print(f"Après set_seconde(3665): {horloge.afficher_heure()}")  # Affiche : "01:06:05"

horloge.set_time(5, 10, 30)
print(f"Après set_time(5, 10, 30): {horloge.afficher_heure()}")  # Affiche : "05:10:30"
