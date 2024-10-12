using UnityEngine;
using UnityEngine.SceneManagement;

public class InformationSceneLoader : MonoBehaviour
{
    // Méthode pour charger une scène par son index
    public void LoadSceneByIndex(int index)
    {
        // Assurez-vous que l'index est valide pour éviter les erreurs
        if (index >= 0 && index < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(index);
            Debug.Log("Chargement de la scène à l'index : " + index);
        }
        else
        {
            Debug.LogError("Index de scène invalide : " + index);
        }
    }

    // Méthode pour charger une scène par son nom
    public void LoadSceneByName(string sceneName)
    {
        // Essaye de charger la scène par son nom
        SceneManager.LoadScene(sceneName);
        Debug.Log("Chargement de la scène : " + sceneName);
    }

    // Méthode pour charger une scène en passant la scène en paramètre
    public void LoadScene(Scene scene)
    {
        // Charge la scène directement en utilisant son nom
        SceneManager.LoadScene(scene.name);
        Debug.Log("Chargement de la scène : " + scene.name);
    }

    // Exemple d'utilisation
    void Start()
    {
        // Appel de méthodes pour charger des scènes
        // ChargeSceneByIndex(1); // Décommentez pour charger la scène à l'index 1
        // LoadSceneByName("NomDeLaScene"); // Décommentez pour charger une scène par son nom
    }
}

/*

Les scènes dans Unity sont des environnements distincts ou des niveaux de jeu dans lesquels les GameObjects et les éléments de gameplay sont placés. 
Chaque scène peut contenir des éléments comme des personnages, des objets interactifs, des lumières, des caméras et des scripts, permettant ainsi de 
créer des expériences variées et complexes.

                                                            Caractéristiques des scènes 

    Organisation 

Les scènes permettent de diviser un projet en différentes sections, facilitant ainsi la gestion et la navigation dans le contenu. 
Par exemple, tu peux avoir une scène pour le menu principal, une pour le niveau 1, et une autre pour le niveau 2.

    Chargement et Déchargement

Les scènes peuvent être chargées et déchargées dynamiquement pendant le jeu. Cela permet de passer d'un niveau à un autre sans avoir à tout recharger.

    Éditeur de scènes

Unity offre un éditeur visuel pour créer et modifier des scènes. Tu peux glisser et déposer des GameObjects, ajuster leurs propriétés 
et voir les changements en temps réel.

*/