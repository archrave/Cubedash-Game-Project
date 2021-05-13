using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public Text x;
    public Transform playerpo;

    // Update is called once per frame
    void Update()
    {
        x.text = playerpo.position.z.ToString("0");
    }
}
