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

/*

Les triggers et les zones de collision sont des concepts clés dans le moteur de jeu Unity qui permettent de gérer les 
interactions entre les objets dans un environnement 3D ou 2D.

=== Triggers === 

Un trigger est une zone définie par un collider qui n'interfère pas physiquement avec d'autres objets, mais qui détecte 
les entrées et sorties d'autres colliders. Lorsqu'un objet entre ou sort d'un trigger, Unity appelle des événements 
spécifiques, tels que OnTriggerEnter(), OnTriggerExit(), et OnTriggerStay(). Les triggers sont souvent utilisés pour 
déclencher des événements de jeu, comme ouvrir une porte, activer un mécanisme ou déclencher une animation, 
sans que les objets ne se bloquent physiquement.

=== Zones de Collision ===

Les zones de collision, en revanche, utilisent également des colliders, mais elles impliquent une interaction physique entre 
les objets. Lorsqu'un collider entre en collision avec un autre, des forces peuvent agir, comme la friction et la gravité, et 
les objets peuvent se repousser ou se bloquer. Les zones de collision sont utilisées pour gérer la physique du jeu, comme les 
collisions entre le personnage du joueur et le sol, ou entre un projectile et un ennemi.

=== Différences === 

La principale différence entre les triggers et les zones de collision réside dans leur comportement : les triggers détectent 
les interactions sans imposer de forces physiques, tandis que les zones de collision engendrent des interactions physiques 
réelles. Cela permet aux développeurs de concevoir des mécanismes de jeu variés et interactifs, en choisissant judicieusement 
entre ces deux types de colliders en fonction des besoins du gameplay.

*/