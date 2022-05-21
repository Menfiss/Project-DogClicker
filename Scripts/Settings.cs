using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public Variables V;

    public void SetFullScreen(bool IsFullScreen1)
    {
        Screen.fullScreen = IsFullScreen1;
    }
}