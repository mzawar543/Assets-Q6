using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    private Rigidbody playerRb;
    public float playerSpeed=10;
    public Vector3 mouseInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput=Input.GetAxisRaw("Horizontal");
        mouseInput=Input.mousePosition;
        playerRb.AddForce(Vector3.forward*verticalInput*playerSpeed);
        playerRb.AddForce(Vector3.right*horizontalInput*playerSpeed);
       

    }
}
