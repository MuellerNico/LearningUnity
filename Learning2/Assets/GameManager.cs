
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public float restartDelay = 1f;
    public GameObject completedLevelUI;


    public void EndGame() {
        if (gameOver == false)
        {
            gameOver = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", 2f);
        }
    }    
    void Restart()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompletedLevel() {
        Debug.Log("LEVEL COMPLETED");
        completedLevelUI.SetActive(true);
        Invoke("LoadMenu", 2);
    }

    public void LoadMenu() {
        SceneManager.LoadScene("Menu");
    }
}
