using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the animals and food bone forward to where they are facing.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
