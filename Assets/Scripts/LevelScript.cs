using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    [SerializeField] int nBlokHancur;
    //objek reference ke SceneLoader
    SceneLoader pindahScene;

    private void Start()
    {
        pindahScene = FindObjectOfType<SceneLoader>();
    }

    public void HitungBlok()
    {
        nBlokHancur++;
    }
    
    public void BlokHancur()
    {
        nBlokHancur--;
        if (nBlokHancur <= 0)
        {
            pindahScene.LoadNextScene();
        }
    }
}
