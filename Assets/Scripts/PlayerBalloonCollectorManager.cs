using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBalloonCollectorManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Balloon")
        {
            Destroy(other.gameObject);
        }
    }
}
