using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrapScript : MonoBehaviour {
    public GameObject Trap;
    public Transform[] Spikes;
    public int Spikesindex;
    public float waktujeda;
    void Update() {
        StartCoroutine(jedakeluartrap());
       
    }

    IEnumerator jedakeluartrap ()
    {
        if (waktujeda > 0) {
            waktujeda -= Time.deltaTime;
            yield return 0;
        } else
        {
            waktujeda = 3f;
            Spikesindex = Random.Range(0, Spikes.Length);
            Instantiate(Trap, Spikes[Spikesindex].position, Spikes[Spikesindex].rotation);
        }
    }

}

