using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    public float _speed; 
    public GameObject _object; 
    // Start is called before the first frame update
    void Start()
    {
         _speed = Random.Range(20, 50);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0 , _speed * Time.deltaTime, 0); 
    }
}
