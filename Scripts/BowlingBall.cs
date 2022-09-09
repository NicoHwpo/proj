using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    public float forwardForce;
    public float leftBorder;
    public float rightBorder;
    public float increment;

    int counter = 0;
    

    public Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bowl()
    {

        if(counter == 0)
        {
            rig.AddForce(transform.forward * forwardForce, ForceMode.Impulse);
            counter = 1;
        }
    }

    public void MoveLeft()
    {
        if(this.transform.position.x > leftBorder && counter == 0)
        {
            this.transform.position += new Vector3(-increment, 0f, 0f);

        }
    }

    public void MoveRight()
    {
        if(this.transform.position.x < rightBorder && counter == 0)
        {
            this.transform.position += new Vector3(increment, 0f, 0f);
        }
    }
}
