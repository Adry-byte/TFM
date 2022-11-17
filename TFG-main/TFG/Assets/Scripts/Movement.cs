using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float movementSpeed = 7.0f;
    float horizontalSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) transform.position += transform.forward * Time.deltaTime * movementSpeed;
        if (Input.GetKey(KeyCode.S)) transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        if (Input.GetKey(KeyCode.A)) transform.position -= transform.right * Time.deltaTime * movementSpeed;
        if (Input.GetKey(KeyCode.D)) transform.position += transform.right * Time.deltaTime * movementSpeed;

        float angle1 = horizontalSpeed * Input.GetAxis("Mouse X");
        float angle2 = horizontalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(0, angle1, 0);

    }
}
