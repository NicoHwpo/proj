using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveForce;

    public Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");

        rig.AddForce(Vector3.right * xInput *moveForce);
    }
}
