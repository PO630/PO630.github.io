using UnityEngine;

public class InformationUnity : MonoBehaviour
{
    // Variable d'exemple
    public int score = 0;
    public GameObject informationUnity;

    // Cette fonction est appelée une seule fois au début
    void Start()
    {
        // Initialisation
        informationUnity = GameObject.Find("InformationUnity"); // Trouve un GameObject nommé "Player"
        
        // Vérification de la présence du GameObject
        if (player != null)
        {
            Debug.Log("Le informationUnity a été trouvé !");
        }
        else
        {
            Debug.Log("Le informationUnity n'a pas été trouvé !");
        }

        // Exemple de boucle for
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Boucle For - itération : " + i);
        }

        // Exemple de boucle while
        int counter = 0;
        while (counter < 5)
        {
            Debug.Log("Boucle While - compteur : " + counter);
            counter++;
        }

        ShowLogExamples(); // Appelle la méthode pour démontrer les logs


    }

    // Cette fonction est appelée une fois par frame
    void Update()
    {
        // Exemple d'augmentation du score avec une condition
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10; // Ajoute 10 au score
            Debug.Log("Score actuel : " + score);
        }

        // Utilisation de GetComponent
        InformationUnity informationUnity2 = informationUnity.GetComponent<InformationUnity>();

    }

    // Méthode pour montrer les différents types de logs
    private void ShowLogExamples()
    {
        // Log normal
        Debug.Log("Ceci est un message d'information.");

        // Log d'avertissement
        Debug.LogWarning("Ceci est un message d'avertissement !");

        // Log d'erreur
        Debug.LogError("Ceci est un message d'erreur !");
    }

    


}
