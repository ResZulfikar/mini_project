using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PergerakanRaket : MonoBehaviour
{
    
    void FixedUpdate()
    {
        int speed = Random.Range(20, 26);
        //pergerakan raket
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * speed; //atribut vector2(posisi x, posisi y) 
                                                                              //artinya raket hanya bergerak di sumbu x
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0) * speed;
        }
    }
}
