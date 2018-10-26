using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float rotatingSpeed = 5.0f;

    private void Start()
    {
        Debug.Log("This is a new startup message !");
    }

    void Update () 
    {
        this.transform.Rotate(Vector3.up * Time.deltaTime * rotatingSpeed); // This is a comment from GitHub
        this.transform.Rotate(Vector3.right * Time.deltaTime * rotatingSpeed); // Second Comment from GitHub
    }
}
