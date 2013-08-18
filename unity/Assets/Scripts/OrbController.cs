using UnityEngine;
using System.Collections;

public class OrbController : MonoBehaviour {
    // Use this for initialization
    void Start () {

    }
	
    // Update is called once per frame
    void Update () {
        const float force = 500.0f;

        this.rigidbody.AddForce(new Vector3(force * Input.GetAxis("Horizontal"), force * Input.GetAxis("Vertical"), 0.0f));
    }
}
