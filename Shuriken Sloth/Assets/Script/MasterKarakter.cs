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
        //Rigidbody rb = GetComponent<Rigidbody>();
        //if (Input.GetKey(KeyCode.A)){
        //    rb.AddForce(Vector3.left);
        //}
        //if (Input.GetKey(KeyCode.S)){
        //    rb.AddForce(Vector3.down);
        //}
        //if (Input.GetKey(KeyCode.D)){
        //    rb.AddForce(Vector3.right);
        //}
        //if (Input.GetKey(KeyCode.W)){
        //    rb.AddForce(Vector3.up);
        //}
        //Navigasi2();
        Navigasi();
        Tembak();
    }


    void Navigasi2()
    {
        float movementSpeed = 10f ;
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveVertical, 0.0f, moveHorizontal);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

    }

    void Navigasi()
    {
        if (Input.GetKey(KeyCode.W))

        {
            transform.rotation = Quaternion.EulerAngles(0, -90, 0);
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.EulerAngles(0, 90, 0);
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.EulerAngles(0, 0, 0);
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.EulerAngles(0, -180, 0);
            transform.Translate(speed * Time.deltaTime, 0, 0);
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

