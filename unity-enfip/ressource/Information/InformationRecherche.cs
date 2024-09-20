using UnityEngine;

public class InformationRecherche : MonoBehaviour
{
    // Méthode pour trouver tous les objets avec le tag "Entity"
    public void FindAllEntities()
    {
        GameObject[] entities = GameObject.FindGameObjectsWithTag("Entity");
        Debug.Log("Nombre d'entités trouvées : " + entities.Length);

        foreach (GameObject entity in entities)
        {
            Debug.Log("Entité trouvée : " + entity.name);
        }
    }

    // Méthode pour trouver tous les objets avec le script InformationRecherche
    public void FindAllInformationRechercheScripts()
    {
        InformationRecherche[] scripts = FindObjectsOfType<InformationRecherche>();

        Debug.Log("Nombre de scripts InformationRecherche trouvés : " + scripts.Length);

        foreach (InformationRecherche script in scripts)
        {
            Debug.Log("Script trouvé sur : " + script.gameObject.name);
        }
    }

    // Exemple d'utilisation des méthodes
    void Start()
    {
        FindAllEntities();
        FindAllInformationRechercheScripts();
    }
    
}
