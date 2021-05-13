
using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public Transform playerOBJ;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = playerOBJ.position + offset;
    }
}
