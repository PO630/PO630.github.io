using System.Collections;
using UnityEngine;

public class InformationInstantiate : MonoBehaviour
{
    public GameObject prefab;           // Le prefab à instancier
    public Transform[] waypoints;       // Tableau de waypoints
    public float instantiateDelay = 1f; // Délai entre les instantiations

    private void Start()
    {
        // Démarre la coroutine pour instancier les objets
        StartCoroutine(InstantiateObjects());
    }

    private IEnumerator InstantiateObjects()
    {
        // Boucle à travers chaque waypoint
        for (int i = 0; i < waypoints.Length; i++)
        {
            // Instancie le prefab à la position du waypoint
            Instantiate(prefab, waypoints[i].position, waypoints[i].rotation);

            // Attend le délai spécifié avant d'instancier le suivant
            yield return new WaitForSeconds(instantiateDelay);
        }
    }
}
