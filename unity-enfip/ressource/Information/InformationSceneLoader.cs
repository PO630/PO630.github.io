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
