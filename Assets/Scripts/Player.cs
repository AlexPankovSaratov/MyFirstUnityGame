using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float FrameShiftX;
    public float Speed;
    public float maxSpeed;
    public float xMin;
    public float xMax;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.S) && Speed > 0)
        {
            Speed -= 0.00005f;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Speed += 0.00003f;
        }
        else if (Speed > 0)
        {
            Speed -= 0.00001f;
        }
        
        if (Input.GetKey(KeyCode.A) && Speed > 0)
        {
            transform.position = new Vector3(
                transform.position.x - FrameShiftX,
                transform.position.y,
                transform.position.z
                );
        }
        if (Input.GetKey(KeyCode.D) && Speed > 0)
        {
            transform.position = new Vector3(
                transform.position.x + FrameShiftX,
                transform.position.y,
                transform.position.z
                );
        }
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, xMin, xMax),
            transform.position.y,
            transform.position.z);
        Speed = Mathf.Clamp(Speed, 0, maxSpeed);
    }
}
