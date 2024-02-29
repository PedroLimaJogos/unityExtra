using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(teste))]
public class testeEditor : Editor
{
    // Start is called before the first frame update

    public override void OnInspectorGUI()
    {
        teste myTarget = (teste)target;

        if (GUILayout.Button("Create teste"))
        {
            myTarget.createObject();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
