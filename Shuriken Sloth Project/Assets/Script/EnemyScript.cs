using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyScript: MonoBehaviour
{
    public Transform Player;
    public float Speed = 5;
    
    void Update()
    {
        Vector3 SelisihPosisi = Player.transform.position - this.transform.position;
        if (Vector3.Distance(Player.position, transform.position)<10)
        {
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(SelisihPosisi), 0.1f);
            this.transform.Translate(0, 0, Speed * Time.deltaTime);

            Debug.Log("Player Approaching");
        
        }
    }
}