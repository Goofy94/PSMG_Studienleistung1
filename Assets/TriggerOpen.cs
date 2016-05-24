using UnityEngine;
using System.Collections;

public class TriggerOpen : MonoBehaviour {
    private Door door;

    void OnTriggerEnter()
    {
        door.open();
    }
}
