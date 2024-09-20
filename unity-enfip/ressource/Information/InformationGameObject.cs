using UnityEngine;

public class InformationGameObject : MonoBehaviour
{
    void Start()
    {
        // Exemple d'accès aux propriétés du GameObject
        ShowGameObjectInfo(gameObject);
    }

    // Méthode pour afficher des informations sur un GameObject
    void ShowGameObjectInfo(GameObject obj)
    {
        // Afficher le nom du GameObject
        Debug.Log("Nom de l'objet : " + obj.name);

        // Afficher le tag du GameObject
        Debug.Log("Tag de l'objet : " + obj.tag);

        // Afficher la position du Transform
        Debug.Log("Position : " + obj.transform.position);

        // Afficher la rotation du Transform
        Debug.Log("Rotation : " + obj.transform.rotation);

        // Afficher l'échelle du Transform
        Debug.Log("Échelle : " + obj.transform.localScale);

        // Accéder à d'autres composants (si disponibles)
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Debug.Log("Masse : " + rb.mass);
        }
        else
        {
            Debug.Log("Pas de Rigidbody trouvé.");
        }

        // Exemple de changement de la position
        obj.transform.position += new Vector3(1, 0, 0); // Déplace l'objet d'une unité sur l'axe X
        Debug.Log("Nouvelle position : " + obj.transform.position);
    }
}
