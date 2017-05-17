using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOrbit : MonoBehaviour
{

    public GameObject Star;
    public GameObject Ship;

    //private Transform target;
    private Vector3 dir;
    private Vector3 forward;
    private Vector3 side;
    private Vector3 cross;

    // Use this for initialization
    void Start()
    {
        forward = transform.forward; //forward vector just to have it (in 3d you need a plane to calculate normalvector, this will be one side of the plane)
        dir = Star.transform.position - transform.position; //direction from your object towards the target object what you will orbit (the other side of the plane)
        side = Vector3.Cross(dir, forward); //90 degrees (normalvector) to the plane closed by the forward and the dir vectors
    }

    // Update is called once per frame
    void Update()
    {
        dir = Star.transform.position - transform.position;
        transform.LookAt(dir.normalized); // look at the target
        GetComponent<Rigidbody>().AddForce(dir.normalized * 50);//add gravity like force pulling your object towards the target
        cross = Vector3.Cross(dir, side); //90 degrees vector to the initial sideway vector (orbit direction) /I use it to make the object orbit horizontal not vertical as the vertical lookatmatrix is flawed/
        GetComponent<Rigidbody>().AddForce(cross.normalized * 50); //add the force to make your object move (orbit)
    }
}
