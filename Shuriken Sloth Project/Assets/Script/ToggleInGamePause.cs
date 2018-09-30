using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleInGamePause : MonoBehaviour {

    public Toggle musicA;

    private void Update()
    {
        if (musicA.isOn)
        {
            BGM.instance.source.mute = false;
        }
        else
        {
            BGM.instance.source.mute = true;
        }
    }
}
