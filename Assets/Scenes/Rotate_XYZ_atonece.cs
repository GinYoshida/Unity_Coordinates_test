using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_XYZ_atonece : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(AngleSet.Rx, AngleSet.Ry, AngleSet.Rz, Space.World);
        Debug.Log("Rotate_XYZ_atonece: Orientation: " + gameObject.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
