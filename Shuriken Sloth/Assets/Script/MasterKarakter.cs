using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterKarakter : MonoBehaviour
{
    public GameObject Pelurunya;
    public GameObject PosisiPeluru;
    public GameObject GameOver;
    public static MasterKarakter instance;

    public float turnSpeed = 10f;
    public float speed = 60;
    private bool run;
    private bool attack;
    public int hp;
    public GameObject[] HPgambar;
    Animator animator;
    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
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
        Putar();
        if (hp <= 0)
        {

            GameOver.SetActive(true);
        }
    }


    void Navigasi2()
    {
        float movementSpeed = 10f;
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveVertical, 0.0f, moveHorizontal);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

    }

    void Navigasi()
    {
        run = false;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            run = Input.GetKey(KeyCode.W);
            animator.SetBool("run", run);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
            run = Input.GetKey(KeyCode.S);
            animator.SetBool("run", run);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            run = Input.GetKey(KeyCode.D);
            animator.SetBool("run", run);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            run = Input.GetKey(KeyCode.A);
            animator.SetBool("run", run);
        }
        else
        {
            animator.SetBool("run", run);
        }
    }

    void Tembak()
    {
        attack = false;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attack = Input.GetKeyDown(KeyCode.Space);
            animator.Play("Idle Attack");
            StartCoroutine(JedaTembak());

        }

        else
        {
            animator.SetBool("attack", false);
        }
    }

    void Putar() {
        if (Input.GetKey(KeyCode.Q)) {

            transform.Rotate(0, -turnSpeed, 0);
            //transform.Rotate(Vector3.up, turnSpeed* Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.E)) {

            transform.Rotate(0, turnSpeed, 0);
        }
    }
    IEnumerator JedaTembak()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(Pelurunya, PosisiPeluru.transform.position, PosisiPeluru.transform.rotation);
       

    }
}

