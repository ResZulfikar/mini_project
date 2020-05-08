using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SensorScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //saat sesuatu melewati atau mentriger tembok
    {
        SceneManager.LoadScene("GameOver");
    }
}
