using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Range(0,20), SerializeField, Tooltip("Velocidad lineal máxima del carro")]
    private float speed = 20f;
    [Range(0,90), SerializeField, Tooltip("Velocidad de giro máxima del carro")]
    private float turnSpeed = 45f;
    private float horizontalInput, verticalInput;

    private void Awake() {
        Debug.Log("El objeto está despertando" + gameObject.name);
    }

    private void LateUpdate() {
        Debug.Log("Esto es el LateUpdate" + gameObject.name);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start" + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");//Valor entre -1 y 1 ((-1 a 0): izquierda, (0 a 1): derecha ), cantidad de movimiento al presionar una tecla
        verticalInput = Input.GetAxis("Vertical");
        // Debug.Log("Movimiento horizontal: " + horizontalInput);

        // S = s0 + V * t * direccion
        /*
        20 = velocidad
        Time.deltaTime = tiempo que transcurre de un frame a otro
        dirección = Vector3.forward
        */
        transform.Translate(speed * Time.deltaTime * Vector3.forward * verticalInput);
        transform.Rotate(turnSpeed * Time.deltaTime * Vector3.up * horizontalInput);
    }
}
