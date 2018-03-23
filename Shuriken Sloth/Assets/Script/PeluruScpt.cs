using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruScpt : MonoBehaviour {
    public float SpeedPeluru;
	// Use this for initialization
	void Start () {
        Destroy(gameObject,5);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0,0,SpeedPeluru*Time.deltaTime);
	}
}
