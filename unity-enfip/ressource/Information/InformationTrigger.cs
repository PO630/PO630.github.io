using UnityEngine;

public class InformationTrigger : MonoBehaviour
{
    // Méthode appelée lorsque l'objet entre dans le trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Objet entré dans le trigger : " + other.name);

        // Exemple d'action lorsque le joueur entre dans le trigger
        if (other.CompareTag("Player"))
        {
            Debug.Log("Le joueur a déclenché le trigger !");
            // Ajouter ici des actions spécifiques, par exemple :
            // Activate a power-up, open a door, etc.
        }
    }

    // Méthode appelée tant que l'objet reste dans le trigger
    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Objet reste dans le trigger : " + other.name);
        
        // Actions répétées tant que l'objet est dans le trigger
        if (other.CompareTag("Player"))
        {
            Debug.Log("Le joueur est toujours dans le trigger.");
            // Exemple : infliger des dégâts au joueur chaque seconde
        }
    }

    // Méthode appelée lorsque l'objet sort du trigger
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Objet sorti du trigger : " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Le joueur a quitté le trigger.");
            // Ajouter ici des actions spécifiques, par exemple :
            // Désactiver un effet, fermer une porte, etc.
        }
    }
}
