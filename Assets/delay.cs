using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delay : MonoBehaviour
{
    public AudioSource delayedSound;
    public float delayTime = 60f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("playaudio", delayTime);
    }

    void playaudio() 
    {

        delayedSound.Play();
    
    }
}
