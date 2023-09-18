using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //
    public KeyCode teleportKey = KeyCode.T;
    public Transform teleportTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(teleportKey))
        {
            TeleportOnKey();
        }
    }

    private void TeleportOnKey()
    {
        if (teleportTarget != null)
        {
            // Teleport the GameObject to the teleport target's position
            transform.position = teleportTarget.position;
            Debug.Log("Teleported to the new position.");
        }
        else
        {
            Debug.LogWarning("Please assign a teleport target (transform) in the Inspector.");
        }
    }
}



/*
 using UnityEngine;

public class TeleportOnKeystroke : MonoBehaviour
{
    public KeyCode teleportKey = KeyCode.Space;
    public Transform teleportTarget;

    private void Update()
    {
        if (Input.GetKeyDown(teleportKey))
        {
            Teleport();
        }
    }

    private void Teleport()
    {
        if (teleportTarget != null)
        {
            // Teleport the GameObject to the teleport target's position
            transform.position = teleportTarget.position;
            Debug.Log("Teleported to the new position.");
        }
        else
        {
            Debug.LogWarning("Please assign a teleport target (transform) in the Inspector.");
        }
    }
}

 
 */