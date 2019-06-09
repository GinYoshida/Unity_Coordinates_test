using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intrinsic_ZYX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, AngleSet.Rz, Space.Self);
        transform.Rotate(AngleSet.Rx, 0, 0, Space.Self);
        transform.Rotate(0, AngleSet.Ry, 0, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
