using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public GameObject pauseMenuUI;  // Référence à l'UI du menu de pause
    private bool isPaused = false;  // État du jeu (en pause ou non)

    void Update()
    {
        // Vérifie si la touche Échap est pressée
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();  // Si le jeu est en pause, on reprend le jeu
            }
            else
            {
                PauseGame();  // Sinon, on met en pause
            }
        }
    }

    // Méthode pour mettre en pause le jeu
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);  // Affiche le menu de pause
        Time.timeScale = 0f;          // Arrête le temps dans le jeu
        isPaused = true;              // Met à jour l'état de pause
    }

    // Méthode pour reprendre le jeu
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false); // Cache le menu de pause
        Time.timeScale = 1f;          // Reprend le temps dans le jeu
        isPaused = false;             // Met à jour l'état de pause
    }

    // Méthode pour retourner au menu principal
    public void LoadMainMenu()
    {
        Time.timeScale = 1f;          // S'assure que le temps n'est plus en pause
        SceneManager.LoadScene("MainMenu");  // Charge la scène du menu principal
    }


}
