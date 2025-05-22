using UnityEngine;

public class PlaneController2 : MonoBehaviour
{

    [Range(0, 20), SerializeField]
    private float speed = 40f;
    [Range(0, 45), SerializeField]
    private float turnSpeed = 45f;
    private float horizontalInput, verticalInput, jumpInput;

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");//Valor entre -1 y 1 ((-1 a 0): izquierda, (0 a 1): derecha ), cantidad de movimiento al presionar una tecla
        verticalInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");

        transform.Rotate(turnSpeed * Time.deltaTime * Vector3.left * verticalInput);
        transform.Rotate(turnSpeed * Time.deltaTime * Vector3.up * horizontalInput);

        transform.Translate(speed * Time.deltaTime * Vector3.forward * jumpInput);
    }
}