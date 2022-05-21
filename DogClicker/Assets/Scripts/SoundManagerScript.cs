using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManagerScript : MonoBehaviour
{
    
    public static AudioClip BuySound, ClickSound, CorrectSound, ErrorSound;
    
    public static AudioSource AudioSrc;
    


    void Start()
    {
        AudioSrc = GetComponent<AudioSource>();

        BuySound = Resources.Load<AudioClip>("buy");
        ClickSound = Resources.Load<AudioClip>("click");
        CorrectSound = Resources.Load<AudioClip>("correct");
        ErrorSound = Resources.Load<AudioClip>("error");

    }


    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "click":
                AudioSrc.PlayOneShot(ClickSound);
                break;
            case "buy":
                AudioSrc.PlayOneShot(BuySound);
                break;
            case "correct":
                AudioSrc.PlayOneShot(CorrectSound);
                break;
            case "error":
                AudioSrc.PlayOneShot(ErrorSound);
                break;
        }
    }
    


}
