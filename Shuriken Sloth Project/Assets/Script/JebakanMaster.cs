using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JebakanMaster : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject,3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            MasterKarakter.instance.hp -= 1;
            Destroy( MasterKarakter.instance.HPgambar[MasterKarakter.instance.hp].gameObject);
            //Destroy(col.gameObject);
        }
    }
}
