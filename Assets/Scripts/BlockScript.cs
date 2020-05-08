using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    LevelScript level;

    private void Start()
    {
        level = FindObjectOfType<LevelScript>();
        level.HitungBlok(); //karena setiap block punya script ini maka 
                            // di LevelScript akan mengincrement sesuai jmlh block
    }

    //utk hancurkan blok harus tahu terjadi collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        BlokHancur();
    }

    private void BlokHancur()
    {
        Destroy(gameObject);
        level.BlokHancur();
        //Debug.Log(collision.gameObject.name);
    }
}
