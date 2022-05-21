using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    public Variables V;
    public Slider volumeChanger;
    public void changeVolume()
    {
        AudioListener.volume = volumeChanger.value;
        V.volumeValue = volumeChanger.value;
    }
    private void Start()
    {
        volumeChanger.value = V.volumeValue;
    }

    // Update is called once per frame

}
