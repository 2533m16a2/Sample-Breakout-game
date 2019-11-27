using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketControllar : MonoBehaviour
{
    public int Accel = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(transform.right * Input.GetAxisRaw("Horizontal") * Accel, ForceMode.Impulse);
    }
}
