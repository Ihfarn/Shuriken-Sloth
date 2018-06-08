using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleOnOff : MonoBehaviour {

    public Toggle musicT;

    private void Update()
    {
        if(musicT.isOn)
        {
            BGM.instance.source.mute = false;
        }else
        {
            BGM.instance.source.mute = true;
        }
    }
}
