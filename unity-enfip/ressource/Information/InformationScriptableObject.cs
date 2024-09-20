using UnityEngine;

/*
Voici un exemple de script InformationScriptableObject.cs qui définit un ScriptableObject pour stocker des informations sur un personnage, 
comme son nom, sa vie, son attaque et sa défense. 
*/

// Définition de la classe ScriptableObject
[CreateAssetMenu(fileName = "NewCharacter", menuName = "Character/Information")]
public class InformationScriptableObject : ScriptableObject
{
    // Propriétés du personnage
    public string characterName; // Nom du personnage
    public int health;           // Vie du personnage
    public int attack;           // Attaque du personnage
    public int defense;          // Défense du personnage

    // Méthode pour afficher les statistiques du personnage
    public void DisplayStats()
    {
        Debug.Log($"Nom : {characterName}, Vie : {health}, Attaque : {attack}, Défense : {defense}");
    }
}

/*
ScriptableObject :

    Les ScriptableObjects sont une fonctionnalité de Unity qui permet de créer des objets de données qui peuvent être stockés comme des 
    fichiers d'actifs dans le projet. Ils sont très utiles pour la gestion de données de manière efficace et modulaire.

    Contrairement aux MonoBehaviours, les ScriptableObjects n'ont pas besoin d'être attachés à des GameObjects et 
    peuvent être utilisés pour stocker des données globales ou partagées.


[CreateAssetMenu] :

    Cet attribut permet de créer des instances de ce ScriptableObject depuis le menu d'Unity. Lorsque tu fais un clic droit dans le projet, 
    tu pourras créer un nouvel actif basé sur cette classe sous "Character".

Propriétés :

    characterName, health, attack, et defense sont des propriétés de l'objet qui contiennent les données du personnage.

*/
