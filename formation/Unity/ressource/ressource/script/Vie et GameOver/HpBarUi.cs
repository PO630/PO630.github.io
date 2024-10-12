using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HpBarUi : MonoBehaviour
{
    #region Singleton
    public static HpBarUi instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Il y a déjà un HpBarUi dans la scène !");
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion 

    // Référence au slider de la barre de vie
    public Slider hpSlider;

    // Référence au texte affichant les points de vie (avec TextMeshPro)
    public TextMeshProUGUI hpText;

    // Méthode pour mettre à jour la barre de vie et le texte
    public void SetHpBarValue(int hp, int hpMax)
    {
        // Met à jour la valeur du slider
        hpSlider.value = (float)hp / hpMax;

        // Met à jour le texte avec le format "hp/hpMax"
        hpText.text = hp + " / " + hpMax;
    }
}
