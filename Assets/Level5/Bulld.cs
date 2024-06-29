using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulld : MonoBehaviour
{
    public float _MoveSpeed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Time.deltaTime * _MoveSpeed, 0 , 0 ); 
    }
}
