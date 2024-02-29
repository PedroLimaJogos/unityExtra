using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject;
    public List<int> list;
    public Vector3 vec;

    void Start()
    {
        vec.Scale(vec);
        Debug.Log(list.GetRandom());

    }

    // Update is called once per frame
    void Update()
    {

    }
}
