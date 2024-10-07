using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelLoader : MonoBehaviour
{
    public string sceneToLoad;  // Nom de la scène à charger
    public float delayBeforeLoading = 1f; // Délai avant de charger la nouvelle scène

    // Détection du trigger lorsque le joueur entre dans la zone
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

           // Désactive le mouvement du joueur pendant le chargement
            StartCoroutine( collision.gameObject.GetComponent<PlayerController>().EnableMovementAfterDelay(delayBeforeLoading) );

            Debug.Log("Le joueur a activé le changement de scène.");
            StartCoroutine(LoadSceneAsync());
        }
    }

    // Coroutine pour charger la scène de manière asynchrone
    IEnumerator LoadSceneAsync()
    {
        yield return new WaitForSeconds(delayBeforeLoading);  // Optionnel : Ajoute un petit délai

        // Commence à charger la scène asynchrone
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad);

        // Tant que la scène n'est pas complètement chargée, affiche la progression dans la console
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);  // Normalise la progression entre 0 et 1
            Debug.Log("Chargement en cours : " + (progress * 100f) + "%");

            yield return null;  // Attend la prochaine frame avant de continuer
        }

        Debug.Log("Scène " + sceneToLoad + " chargée !");
    }
}
