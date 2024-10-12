using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    private bool isLoading = false;  // Empêche de lancer plusieurs chargements en même temps
    public string levelToLoad;       // Le nom du niveau à charger, paramétré dans l'Inspector

    // Méthode pour quitter l'application
    public void Exit()
    {
        if (!isLoading)  // Si le chargement n'est pas en cours, on peut quitter
        {
            Debug.Log("Quitter l'application.");
            Application.Quit();  // Quitte l'application (fonctionne dans une build, pas dans l'éditeur)
        }
    }

    // Méthode pour lancer le niveau spécifié de manière asynchrone
    public void Play()
    {
        if (!isLoading && !string.IsNullOrEmpty(levelToLoad))  // Si le chargement n'est pas déjà en cours et que le nom de la scène est spécifié
        {
            Debug.Log("Lancement du niveau : " + levelToLoad);
            StartCoroutine(LoadLevelAsync(levelToLoad));  // Charge le niveau spécifié
        }
        else if (string.IsNullOrEmpty(levelToLoad))
        {
            Debug.LogWarning("Aucun niveau à charger n'a été spécifié !");
        }
    }

    // Coroutine pour charger la scène de manière asynchrone avec une string
    IEnumerator LoadLevelAsync(string sceneName)
    {
        isLoading = true;  // Bloque l'accès aux méthodes pendant le chargement

        // Commence à charger la scène asynchrone
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // Tant que la scène n'est pas complètement chargée, affiche la progression dans la console
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);  // Normalise la progression entre 0 et 1
            Debug.Log("Chargement en cours : " + (progress * 100f) + "%");

            yield return null;  // Attend la prochaine frame avant de continuer
        }

        Debug.Log("Niveau " + sceneName + " chargé !");
        isLoading = false;  // Réactive les méthodes une fois le chargement terminé
    }
}
