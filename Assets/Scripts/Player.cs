using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Vector3 posicion1 = new Vector3(0,0,0);

    CharacterController characterController;

    Vector3 move = Vector3.zero;

    float speed = 2;

    float moveMouseH = 0;
    float moveMouseV = 0;

    float speedMouseH = 2;
    float speedMouseV = 2;

    public GameObject camera;


    // Start is called before the first frame update
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(transform.TransformDirection(move) * speed * Time.deltaTime);


        moveMouseH = Input.GetAxis("Mouse X") * speedMouseH;
        moveMouseV = Input.GetAxis("Mouse Y") * speedMouseV;

        gameObject.transform.Rotate(0, moveMouseH,0);
        camera.transform.Rotate(moveMouseV, 0, 0);

    }
}
