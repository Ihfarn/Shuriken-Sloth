using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyScriptPatrol : MonoBehaviour {
    public float waktu;
    public float speed;
    public Rigidbody rb;
   public float health;

  
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(wait(waktu));
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector3(speed, 0f, 0f);
        

    }

    IEnumerator wait(float waktu)
    {
        yield return new WaitForSeconds(waktu);
        speed *= -1;
        StartCoroutine(wait(waktu));
    }
    private void OnTriggerEnter(Collider collision)
    {
       if (collision.gameObject.tag == "shuriken")
        {
            if (health == 0) {

                Destroy(gameObject);
                return;
            } health -= 1;
        }
            
    }

}
