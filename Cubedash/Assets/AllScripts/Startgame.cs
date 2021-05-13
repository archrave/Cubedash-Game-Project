using UnityEngine;
using UnityEngine.SceneManagement;

//Code for changing levels
public class Startgame : MonoBehaviour
{
    public void starto()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //'+1' Increases the level of the game
    }
}
