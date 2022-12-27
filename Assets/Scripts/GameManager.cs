using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public int score;
    public Text scoreText;
    public Text endScoreText;
    public GameObject restartPanel;
    void Start()
    {
        restartPanel.SetActive(false);
    }
    void Update()
    {
        // to check that the game is over
        if(player.isDead == true){
            Time.timeScale = 0;
            restartPanel.SetActive(true);
        }
        // updating our score and to show on scene
        scoreText.text = score.ToString();
        endScoreText.text ="Score: " + score.ToString();
    }

    // when the game is over, restart to scene
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        player.isDead = false;
        Time.timeScale = 1;
        restartPanel.SetActive(false);
    }
}
