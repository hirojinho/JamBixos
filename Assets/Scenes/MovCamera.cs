using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamera : MonoBehaviour
{
    float velocidade = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
            gameObject.transform.position += new Vector3(0, velocidade, 0);
        if (Input.GetKey(KeyCode.S))
            gameObject.transform.position += new Vector3(0, -velocidade, 0);
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.position += new Vector3(-velocidade, 0, 0);
        if (Input.GetKey(KeyCode.D))
            gameObject.transform.position += new Vector3(velocidade, 0, 0);
    }
}
