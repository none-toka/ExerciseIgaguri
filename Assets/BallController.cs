using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "target")
        {
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<ParticleSystem>().Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
