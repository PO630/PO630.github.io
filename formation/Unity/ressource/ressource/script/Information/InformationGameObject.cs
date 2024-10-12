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

/*

Les GameObjects sont les éléments fondamentaux de toute scène dans Unity. 

Ils représentent des objets dans le jeu et peuvent être de différents types, tels que des personnages, des ennemis, 
des éléments de décor, des lumières, des caméras, et bien d'autres encore. Chaque GameObject agit comme un conteneur 
qui peut contenir divers composants.



                                                    Caractéristiques des GameObjects


Composants

Chaque GameObject peut avoir plusieurs composants qui lui ajoutent des fonctionnalités. Par exemple, un GameObject représentant 
un personnage peut avoir un composant de rendu pour afficher son modèle, un composant de physique pour gérer les collisions, et 
des scripts pour définir son comportement.

Transform

Chaque GameObject possède un composant Transform qui définit sa position, sa rotation et son échelle dans l'espace 3D ou 2D. 
Cela permet de placer et d'orienter les objets dans la scène.

Hiérarchie

Les GameObjects peuvent être organisés en une hiérarchie. Un GameObject parent peut contenir des GameObjects enfants, permettant de regrouper 
des objets pour des transformations collectives et une meilleure organisation.

Interaction

Les GameObjects peuvent interagir entre eux par le biais de collisions, de triggers, et de méthodes définies dans des scripts. Cela permet de créer 
des mécaniques de jeu complexes et des interactions dynamiques.



                                                    Utilisation


Dans Unity, les GameObjects sont utilisés pour construire tout le contenu d'un jeu. Que ce soit pour créer un environnement, un système d'UI, ou 
des éléments de gameplay, chaque élément de la scène est un GameObject. Ils sont donc au cœur de la structure de tout projet Unity.

En résumé, les GameObjects sont des éléments essentiels dans Unity qui permettent de créer et d'organiser tous les objets d'une scène, 
tout en ajoutant des comportements et des fonctionnalités grâce aux composants.


*/


