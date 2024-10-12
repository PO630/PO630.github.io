using UnityEngine;

public class SpawnPointChanger : MonoBehaviour
{
    public Transform newSpawnPoint;  // Nouveau point de spawn à définir pour le joueur

    // Méthode déclenchée lors de la collision avec un objet (trigger)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Récupérer le script HeroStats du joueur en collision
        HeroStats heroStats = collision.GetComponent<HeroStats>();

        if (heroStats != null)  // Si le joueur possède un script HeroStats
        {
            ChangeSpawnPoint(heroStats);  // Changer le point de spawn du joueur
        }
    }

    // Méthode pour changer le point de spawn du joueur
    private void ChangeSpawnPoint(HeroStats heroStats)
    {
        if (newSpawnPoint != null)  // Vérifie si le nouveau point de spawn est défini
        {
            heroStats.spawnPoint = newSpawnPoint;  // Met à jour le point de spawn du joueur
            Debug.Log("Nouveau spawn point défini pour le joueur : " + newSpawnPoint.position);
        }
        else
        {
            Debug.LogWarning("Aucun nouveau point de spawn défini !");
        }
    }
}
