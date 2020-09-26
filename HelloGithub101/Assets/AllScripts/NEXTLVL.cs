using UnityEngine;
using UnityEngine.SceneManagement;

public class NEXTLVL : MonoBehaviour
{
    public void plzchangelvl()
    {       
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);     
    }

}

