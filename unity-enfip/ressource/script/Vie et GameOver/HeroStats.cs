using UnityEngine;

public class HeroStats : MonoBehaviour
{
    public int maxHealth = 5;  // Points de vie maximum
    [SerializeField]
    private int currentHealth; // Points de vie actuels

    public Transform spawnPoint; // Point de réapparition en cas de mort

    void Start()
    {
        // Initialiser les points de vie au maximum au démarrage
        currentHealth = maxHealth;

        // Vérifier si le spawnPoint est null
        if (spawnPoint == null)
        {
            Debug.LogError("Le spawnPoint est null. Veuillez définir un point de réapparition pour le joueur.");
        }

        // Mise a jour de l'ui
        if( HpBarUi.instance != null )
        {
            HpBarUi.instance.SetHpBarValue( currentHealth , maxHealth ) ;
        }
    }

    // Méthode pour infliger des dégâts au héros
    public void TakeDamage(int damage)
    {
        // Réduire les points de vie en fonction des dégâts reçus
        currentHealth -= damage;
        Debug.Log("Le héros subit " + damage + " points de dégâts. Points de vie restants: " + currentHealth);

        // Si les points de vie tombent à 0 ou moins, le héros meurt
        if (currentHealth <= 0)
        {
            Die(); // Appel de la méthode Die si le joueur n'a plus de points de vie
        }

        // Mise a jour de l'ui
        if( HpBarUi.instance != null )
        {
            HpBarUi.instance.SetHpBarValue( currentHealth , maxHealth ) ;
        }

    }

    // Méthode appelée lorsque le héros meurt
    private void Die()
    {
        Debug.Log("Le héros est mort.");
        
        // Réinitialiser les points de vie au maximum
        currentHealth = maxHealth;

        // Téléporter le héros au point de réapparition (spawn)
        transform.position = spawnPoint.position;
        Debug.Log("Le héros a été réinitialisé au point de spawn.");
    }
}
