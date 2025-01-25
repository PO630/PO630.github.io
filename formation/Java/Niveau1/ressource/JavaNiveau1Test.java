package fr.gouv.finances.enfip;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertTrue;
import static org.junit.jupiter.api.Assertions.assertFalse;

import org.junit.jupiter.api.Test;

public class JavaNiveau1Test {

    private JavaNiveau1 javaNiveau1 = new JavaNiveau1();

    @Test
    void testEstPair() {
        assertEquals(javaNiveau1.estPair(2), true); // Nombre pair positif
        assertEquals(javaNiveau1.estPair(7), false); // Nombre impair positif
        assertEquals(javaNiveau1.estPair(-4), true); // Nombre pair négatif
        assertEquals(javaNiveau1.estPair(-3), false);// Nombre impair négatif
    }

    @Test
    void testPourcentages() {
        assertEquals(javaNiveau1.pourcentages(100.0, 50), 50.0); // 50% de réduction sur 100€
        assertEquals(javaNiveau1.pourcentages(200.0, 25), 150.0); // 25% de réduction sur 200€
        assertEquals(javaNiveau1.pourcentages(50.0, 10), 45.0); // 10% de réduction sur 50€
        assertEquals(javaNiveau1.pourcentages(80.0, 0), 80.0); // Pas de réduction
        assertEquals(javaNiveau1.pourcentages(60.0, 100), 0.0); // Réduction totale
    }

    @Test
    void testTarif() {
        assertEquals(10.0, javaNiveau1.tarif(30, true));
        assertEquals(16.0, javaNiveau1.tarif(24, false));
        assertEquals(16.0, javaNiveau1.tarif(61, false));
        assertEquals(20.0, javaNiveau1.tarif(30, false));
        assertEquals(10.0, javaNiveau1.tarif(20, true));
        assertEquals(10.0, javaNiveau1.tarif(70, true));
    }

    @Test
    void testEstPremier() {
        assertTrue(javaNiveau1.estPremier(2));
        assertTrue(javaNiveau1.estPremier(3));
        assertTrue(javaNiveau1.estPremier(7));
        assertTrue(javaNiveau1.estPremier(11));

        assertFalse(javaNiveau1.estPremier(1));
        assertFalse(javaNiveau1.estPremier(4));
        assertFalse(javaNiveau1.estPremier(9));
        assertFalse(javaNiveau1.estPremier(10));
    }

    @Test
    public void testIdentifiant() {
        // Test 1 : Identifiant avec des valeurs standards
        String identifiant1 = javaNiveau1.identifiant("Dupont", "Jean", 75, 1234);
        assertEquals("DUPONTjean75_1234", identifiant1);

        // Test 2 : Identifiant avec des noms et prénoms plus courts
        String identifiant2 = javaNiveau1.identifiant("Liu", "Mei", 13, 5678);
        assertEquals("LIUmei13_5678", identifiant2);

        // Test 3 : Identifiant avec des nombres différents
        String identifiant3 = javaNiveau1.identifiant("Martin", "Paul", 92, 8765);
        assertEquals("MARTINpaul92_8765", identifiant3);
    }

    public void testScoreMotDePasse() {
        // Test 1 : Mot de passe sans critères particuliers
        assertEquals(5, javaNiveau1.scoreMotDePasse("abcde"));

        // Test 2 : Mot de passe avec une majuscule
        assertEquals(6, javaNiveau1.scoreMotDePasse("Abcde"));

        // Test 3 : Mot de passe avec une minuscule et un chiffre
        assertEquals(7, javaNiveau1.scoreMotDePasse("abc1e"));

        // Test 4 : Mot de passe avec une minuscule, un chiffre et un caractère spécial
        assertEquals(8, javaNiveau1.scoreMotDePasse("abc!1e"));

        // Test 5 : Mot de passe avec plus de 14 caractères
        assertEquals(26, javaNiveau1.scoreMotDePasse("abcdefghijklmno"));

        // Test 6 : Mot de passe avec plus de 14 caractères et un caractère spécial
        assertEquals(27, javaNiveau1.scoreMotDePasse("abcdefghijklmno!"));

        // Test 7 : Mot de passe avec tous les critères
        assertEquals(34, javaNiveau1.scoreMotDePasse("Abc1!Defghijklmno"));
    }

    @Test
    public void testMailValide() {
        // Test 1: Mail valide avec un "@" et des parties de taille supérieure à 4
        assertTrue(javaNiveau1.mailValide("toto.titi@example.com"));

        // Test 2: Mail invalide avec une partie avant "@" trop courte
        assertFalse(javaNiveau1.mailValide("a@b.co"));

        // Test 3: Mail invalide avec une partie après "@" trop courte
        assertFalse(javaNiveau1.mailValide("test@a.fr"));

        // Test 4: Mail invalide avec plus d'un "@"
        assertFalse(javaNiveau1.mailValide("test@example@example.com"));

        // Test 5: Mail valide avec une partie avant "@" de taille 5 et partie après "@"
        // de taille 5
        assertTrue(javaNiveau1.mailValide("hello@hello"));
    }

}
