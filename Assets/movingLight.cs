using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingLight : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var light = gameObject.GetComponent<movingLight>();
        light.transform.eulerAngles = new Vector3(
            light.transform.eulerAngles.x,
            light.transform.eulerAngles.y + 0.5f,
            light.transform.eulerAngles.z
        );
    }
}
