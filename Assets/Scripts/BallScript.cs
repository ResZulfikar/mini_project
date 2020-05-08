using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //config parameter, supaya bisa melacak posisi x dan y raket
    [SerializeField] PergerakanRaket Raket1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
    //state, jarak antara raket dan ball
    Vector2 raketToBallVector;

    bool hasStarted = false;

    void Start()
    {
        //jarak antara raket dan ball -> posisi ball saat ini [x,y]- posisi raket saat ini[x,y]
        // hasilnya vector = [ x , y ]
        raketToBallVector = transform.position - Raket1.transform.position;
    }
    
    void Update()
    {
        //supaya bola bisa dilempar & gk stuck di LockBalltoRaket
        if (!hasStarted)
        {
            LockBallToRaket();
            LemparBola();
        }
    }

    private void LemparBola()
    {
        if (Input.GetKeyDown("space"))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void LockBallToRaket()
    {
        Vector2 raketPosition = new Vector2(Raket1.transform.position.x, Raket1.transform.position.y);
        //update terus posisi ball = posisi raket [x,y]+ jarak antara ball dan raket [x,y]
        transform.position = raketPosition + raketToBallVector;
    }
}
