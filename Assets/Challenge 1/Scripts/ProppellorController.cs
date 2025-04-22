using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProppellorController : MonoBehaviour
{

    private float proppellorVelocity = 10000f;
    private float jumpIntput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jumpIntput = Input.GetAxis("Jump");
        transform.Rotate(proppellorVelocity * Time.deltaTime * Vector3.forward * jumpIntput);
    }
}
