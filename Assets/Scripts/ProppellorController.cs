using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProppellorController : MonoBehaviour
{

    private float proppellorVelocity = 10000f;


    void Update()
    {
        transform.Rotate(proppellorVelocity * Time.deltaTime * Vector3.forward);
    }
}
