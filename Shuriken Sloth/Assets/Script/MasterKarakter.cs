using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterKarakter : MonoBehaviour
{
    public GameObject Pelurunya;
    public GameObject PosisiPeluru;

    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Navigasi();
        Tembak();
    }

    void Navigasi()
    {
        if (Input.GetKey(KeyCode.W))

        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }

    void Tembak()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Pelurunya,PosisiPeluru.transform.position,PosisiPeluru.transform.rotation);
        }
    }
}

