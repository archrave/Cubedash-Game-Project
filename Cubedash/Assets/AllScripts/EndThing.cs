using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndThing : MonoBehaviour
{
    public Restartgame gm;
    void OnTriggerEnter()
    {
        gm.Completelvl();
    }
}
