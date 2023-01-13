using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickSuter : MonoBehaviour
{
    public GameObject Handle;
    public GameObject Barrell;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Barrell.transform.rotation = Handle.transform.rotation;
    }
}
