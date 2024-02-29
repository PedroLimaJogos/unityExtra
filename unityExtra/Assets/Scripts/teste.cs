using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    // Update is called once per frame
    public void createObject()
    {
        var a = Instantiate(this);
        a.transform.position = Vector3.zero;
    }
}
