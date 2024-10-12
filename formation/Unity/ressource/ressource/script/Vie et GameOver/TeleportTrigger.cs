using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    // Détection du trigger lorsque le joueur entre dans la zone
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Vérifie si l'objet qui entre en collision possède le script HeroStats
        HeroStats heroStats = collision.GetComponent<HeroStats>();
        
        if (heroStats != null)  // Vérifie si le joueur a un script HeroStats attaché
        {
            TeleportPlayer(heroStats);  // Téléporte le joueur à son spawnPoint
        }
    }

    // Méthode pour téléporter le joueur à la position de son spawnPoint
    private void TeleportPlayer(HeroStats heroStats)
    {
        if (heroStats.spawnPoint != null)  // Vérifie que le spawnPoint est défini
        {
            heroStats.transform.position = heroStats.spawnPoint.position;  // Téléporte le joueur au spawn
            Debug.Log("Joueur téléporté au spawn point : " + heroStats.spawnPoint.position);
        }
        else
        {
            Debug.LogWarning("Aucun spawnPoint défini pour le joueur !");
        }
    }
}



/*

Expliqué les avantages et désavantage de se script.

public class TeleportTrigger : MonoBehaviour
{
    private HeroStats heroStats;  // Référence au script HeroStats du joueur

    void Start()
    {
        // Cherche automatiquement le script HeroStats attaché au joueur
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            heroStats = player.GetComponent<HeroStats>();
        }
    }

    // Détection du trigger lorsque le joueur entre dans la zone
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && heroStats != null)  // Vérifie si l'objet est le joueur
        {
            TeleportPlayer(heroStats);  // Téléporte le joueur à son spawnPoint
        }
    }

    // Méthode pour téléporter le joueur à la position de son spawnPoint
    private void TeleportPlayer(HeroStats heroStats)
    {
        if (heroStats.spawnPoint != null)  // Vérifie que le spawnPoint est défini
        {
            heroStats.transform.position = heroStats.spawnPoint.position;  // Téléporte le joueur au spawn
            Debug.Log("Joueur téléporté au spawn point : " + heroStats.spawnPoint.position);
        }
        else
        {
            Debug.LogWarning("Aucun spawnPoint défini pour le joueur !");
        }
    }
}

*/
