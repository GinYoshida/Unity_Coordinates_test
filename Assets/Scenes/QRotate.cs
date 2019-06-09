using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(AngleSet.Rx, AngleSet.Ry, AngleSet.Rz);
        Debug.Log("Quaternion.Eular: Orientation: " + gameObject.transform.rotation);
    }


    void Update()
    {

    }
}
