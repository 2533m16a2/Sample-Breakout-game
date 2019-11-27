using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcollider : MonoBehaviour
{
    public int speed = 20;
    private Rigidbody _rigidbody;
    Vector3 pos0;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
        _rigidbody = this.GetComponent<Rigidbody>();
        Transform myTransform = this.transform;
        pos0 = myTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Transform myTransform = this.transform;
            myTransform.position = pos0;
            GetComponent<Rigidbody>().AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
        }
    }

    void FixedUpdate()
    {
        _rigidbody.velocity *= 28f/_rigidbody.velocity.magnitude;
    }
}
