using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    PickUpManager pickups; // Sahnedeki kapsüllerin referansý
    public GameObject gameOverScreen;

    int totalPickups; // Sahnedeki toplam kapsül sayýsý
    int score = 0;    // Skor sayacý

    private void Start()
    {
        pickups = FindFirstObjectByType<PickUpManager>();
        totalPickups = pickups.amount;
        UpdateScore();
    }

    public void CollectPickup()
    {
        score++;
        UpdateScore();

        if (score >= totalPickups)
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0f; // Oyun durdurulur (tüm kapsüller toplanýnca)
        }
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString() + "\n" + "Erdem Gökhüseyinoðlu";
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}