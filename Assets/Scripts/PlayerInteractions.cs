using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{

    public GameObject gameManager;

    // Update is called once per frame
    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Light")
        {
            EventBus.Current.lightsGoOnTrigger();
        }
    }

    public void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.tag == "Light")
        {
            EventBus.Current.lightsGoOffTrigger();
        }
    }
}
