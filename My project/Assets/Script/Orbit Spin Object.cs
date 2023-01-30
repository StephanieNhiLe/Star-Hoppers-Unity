using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitSpinObject : MonoBehaviour
{
    public GameObject[] Planets; 
    public float[] _planetSpeed; 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _planetSpeed.Length; i++) 
        { 
            _planetSpeed[i] = Random.Range(20,50); 
        } 
    } 


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _planetSpeed.Length; i++) 
        { 
            Planets[i].transform.Rotate(0, _planetSpeed[i] * Time.deltaTime, 0); 
        } 

    }
}
