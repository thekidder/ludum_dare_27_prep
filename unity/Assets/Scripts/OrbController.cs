using UnityEngine;
using System.Collections;

public class OrbController : MonoBehaviour {
    // Use this for initialization
    void Start () {

    }
	
    // Update is called once per frame
    void Update () {
        float distance = 2.0f;

        Vector3 translation = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0.0f);
        if(translation.sqrMagnitude > 0.0)
        {
            translation.Normalize();
        }

        this.transform.Translate(translation * distance);
    }
}
