using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public Transform waypoint1;       // Premier waypoint
    public Transform waypoint2;       // Deuxième waypoint
    public float speed = 2f;          // Vitesse de déplacement
    public int damage = 10;           // Dégâts infligés au joueur
    public bool flipInversi = false;  // Si vrai, inverse le flip du sprite

    private Transform targetWaypoint; // Waypoint cible actuel
    private SpriteRenderer spriteRenderer;  // Pour flipper le sprite

    void Start()
    {
        // Initialement, le monstre se déplace vers le premier waypoint
        targetWaypoint = waypoint1;

        // Récupérer le SpriteRenderer pour pouvoir flip le sprite
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Déplacement vers le waypoint cible
        MoveTowardsWaypoint();
    }

    void MoveTowardsWaypoint()
    {
        // Déplacer le monstre vers le waypoint cible
        transform.position = Vector2.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

        // Flip du sprite selon la direction
        if (targetWaypoint.position.x < transform.position.x)
        {
            spriteRenderer.flipX = flipInversi ? false : true;
        }
        else
        {
            spriteRenderer.flipX = flipInversi ? true : false;
        }

        // Si le monstre atteint le waypoint cible
        if (Vector2.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            // Inverser la cible du waypoint sans utiliser de booléen
            targetWaypoint = (targetWaypoint == waypoint1) ? waypoint2 : waypoint1;
        }
    }

    // Détection de collision avec le joueur
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null )
        {
            // Log les dégâts infligés au joueur
            Debug.Log("Le joueur subit " + damage + " points de dégâts.");
        }
    }*/

    // Détection de collision avec le joueur
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Vérifie si l'objet en collision a un script HeroStats
        HeroStats heroStats = collision.gameObject.GetComponent<HeroStats>();

        if (heroStats != null)
        {
            // Appelle la méthode TakeDamage pour infliger des dégâts
            heroStats.TakeDamage(damage);
        }
    }

}
