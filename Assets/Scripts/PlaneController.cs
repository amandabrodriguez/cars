using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneController : MonoBehaviour
{

    [Range(0, 40), SerializeField]
    private float speed = 40f;
    [Range(0, 120), SerializeField]
    private float turnSpeed = 60f;
    private float verticalInput;


    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(speed * Time.deltaTime * Vector3.forward);
        transform.Rotate(turnSpeed * Time.deltaTime * Vector3.left * verticalInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RoadEnd"))
        {
            SceneManager.LoadScene("Prototype 2");
        }
    }
}
