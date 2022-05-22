using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject kure;
    public int skor;

    void Start()
    {
        kure.GetComponent<MeshRenderer>().material.color=Color.red;       

    }

    void Update()
    {

    if(Input.GetKeyDown(KeyCode.Space))
    skor+=10;

    if(skor>=20)

    
    kure.GetComponent<MeshRenderer>().material.color=Color.blue;
    if(skor>=30)
    kure.GetComponent<MeshRenderer>().material.color=Color.black;
    if(skor>=40)
    kure.GetComponent<MeshRenderer>().material.color=Color.green;
    if(skor>=50)
    kure.GetComponent<MeshRenderer>().material.color=Color.white;
    }
}
