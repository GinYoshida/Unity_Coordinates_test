using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extrinsic_XYZ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(AngleSet.Rx, 0, 0, Space.World);
        transform.Rotate(0, AngleSet.Ry, 0, Space.World);
        transform.Rotate(0, 0, AngleSet.Rz, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
