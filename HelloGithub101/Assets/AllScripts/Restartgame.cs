using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartgame : MonoBehaviour
{
    int isEnd = 0;

    public float delay=2f;

    public GameObject completeUI;

    public void endgame()
    {
        if(isEnd == 0)
        {
            isEnd = 1;
            Debug.Log("Game Over");
            Invoke("Restart", delay);

        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Completelvl()
    {
        Debug.Log("Level Won!");
        completeUI.SetActive(true);
    }
}
