using UnityEngine;
using System.Collections;

public class InformationCoroutine : MonoBehaviour
{
    private void Start()
    {
        // Démarre la coroutine lorsque le script s'initialise
        StartCoroutine(LogMessagesCoroutine());
    }

    // Coroutine pour afficher des messages dans la console
    private IEnumerator LogMessagesCoroutine()
    {
        Debug.Log("Début de la coroutine.");

        // Attendre 1 seconde
        yield return new WaitForSeconds(1f);
        Debug.Log("1 seconde écoulée.");

        // Attendre 2 secondes
        yield return new WaitForSeconds(2f);
        Debug.Log("2 secondes supplémentaires écoulées.");

        // Attendre 1 seconde
        yield return new WaitForSeconds(1f);
        Debug.Log("Fin de la coroutine.");
    }
}

/*

Les coroutines sont une fonctionnalité d'Unity qui permet d'exécuter des opérations sur plusieurs frames, 
plutôt que d'exécuter tout le code en une seule fois. Elles sont particulièrement utiles pour gérer des 
tâches qui nécessitent des délais, comme des animations, des temporisations ou des chargements de ressources.

Lorsqu'une coroutine est lancée, elle peut "mettre en pause" son exécution à un certain point, attendre 
une condition (comme un délai ou un événement) et reprendre là où elle s'était arrêtée. Cela permet 
d'écrire du code plus propre et plus lisible, sans bloquer l'exécution de la logique du jeu. 
Par exemple, on peut faire clignoter un objet, attendre quelques secondes, puis changer son état, 
le tout sans interférer avec le reste du programme.

Les coroutines sont définies comme des méthodes qui retournent IEnumerator, et elles utilisent des 
instructions yield pour indiquer quand elles doivent attendre avant de continuer. Cela en fait un outil 
puissant pour gérer des processus asynchrones tout en gardant une structure claire.

*/