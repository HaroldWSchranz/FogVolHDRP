using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

// 20230911: based on https://medium.com/@mikeyoung_97230/creating-a-simple-camera-controller-in-unity3d-using-c-ec1a79584687
// Modified to allow gradual float speed forward to allow exploring of scene
public class CameraController : MonoBehaviour
{
    //
    public float speed = 5.0f;          // how fast the camera moves
    public float sensitivity = 5.0f;    // how sensitive the mouse movement
    float floatSpeed;

    // Start is called before the first frame update
    void Start()
    {
        floatSpeed = speed/10f; 
    }

    // Update is called once per frame
    void Update()
    {
        // Move the camera forward, backward, left, and right
        transform.position += transform.forward * ( Input.GetAxis("Vertical") * speed + floatSpeed) * Time.deltaTime;
        transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        // Rotate the camera based on the mouse movement
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.eulerAngles += new Vector3(-mouseY * sensitivity, mouseX * sensitivity, 0);

        Debug.Log(" [" + transform.position + "] | (" + mouseX + "," + mouseY + ")");
    }
}
