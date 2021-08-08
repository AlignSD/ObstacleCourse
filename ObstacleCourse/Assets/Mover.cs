using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0.00f;
    [SerializeField] float yValue = 0.02f;
    [SerializeField] float zValue = 0.00f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bonk The Chonk To The Donk.");

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( xValue, yValue, zValue ); // moves component along the x axis.
    }
}
