
using UnityEngine;

public class AddCollision : MonoBehaviour
{

    public MOVEMENT mvmnt;


    void OnCollisionEnter(Collision info)
    {
        if (info.collider.tag == "OBSTACLE")
        {
            mvmnt.enabled = false;
            FindObjectOfType<Restartgame>().endgame();
        }
    }
}
