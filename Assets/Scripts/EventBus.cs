using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventBus : MonoBehaviour
{
    public static EventBus _current;

    public static EventBus Current {get {return _current;}}

    public int lives = 3;

    public event Action lightsGoOn;
    public event Action lightsGoOff;

    private void Awake()
    {
        if(_current != null && _current != this)
        {
            Destroy(this.gameObject);
        } 
        
        else 
        {
            _current = this;

            DontDestroyOnLoad(gameObject);
        }
    }

    public void lightsGoOnTrigger()
    {
        lightsGoOn();
    }

    public void lightsGoOffTrigger()
    {
        lightsGoOff();
    }
    

    public void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void LooseHealth()
    {
        lives--;
    }
    
}
