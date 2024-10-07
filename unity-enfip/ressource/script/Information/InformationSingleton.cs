using UnityEngine;

public class InformationSingleton : MonoBehaviour
{
    #region Singleton
    public static InformationSingleton instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Il y a déjà un InformationSingleton dans la scène !");
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion 

    // Méthode pour afficher des informations
    public void PrintInformation()
    {
        Debug.Log("InformationSingleton : Instance active et prête à l'emploi !");
    }

}

/*

Les singletons sont un modèle de conception qui garantit qu'une classe n'a qu'une seule instance dans l'application et fournit un 
point d'accès global à cette instance. En Unity, cela est souvent utilisé pour des classes qui gèrent des ressources globales ou des 
comportements, comme des gestionnaires de sons, des gestionnaires de niveaux ou des systèmes de configuration.

Le principal avantage des singletons est qu'ils permettent de centraliser la gestion d'un état ou d'une ressource, 
évitant ainsi la création d'instances multiples qui pourraient entraîner des conflits ou des comportements inattendus. 
Par exemple, un gestionnaire de son unique peut contrôler tous les effets sonores et la musique du jeu, assurant ainsi une cohérence.

Pour implémenter un singleton en Unity, on utilise généralement une instance statique de la classe. Lorsqu'une instance 
est demandée, si aucune n'existe, elle en crée une ; sinon, elle renvoie l'instance existante. Cela garantit qu'il n'y a 
jamais plus d'une instance de la classe active. En outre, on peut utiliser DontDestroyOnLoad() pour préserver l'instance 
lorsqu'on change de scène, ce qui est utile pour les éléments qui doivent persister tout au long du jeu.

En résumé, les singletons sont un outil pratique pour gérer des comportements globaux et des ressources, 
facilitant ainsi la structure et la gestion des états dans une application.

*/
