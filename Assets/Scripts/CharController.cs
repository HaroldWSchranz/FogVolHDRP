using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4f;

    Vector3 forward, right;




    // Start is called before the first frame update
    void Start()
    {
        //forward = Camera.main.transform.forward;
        forward = transform.forward;
        forward.y = 0f;
        forward=Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0,90,0))*forward; //90 degrees to forward vector

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            Move();
        }
    }

    void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //X,0,Z
        Vector3 rightMovement =   right * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        Vector3    upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        if(heading != Vector3.zero)
        {
            transform.forward = heading;
            transform.position += rightMovement;
            transform.position += upMovement;
        }
    }

}
