using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Randomizador
{
    public static void Scale(this GameObject t, float size = 1.2f)
    {
        t.transform.localScale = Vector3.one * size;
    }

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    [UnityEditor.MenuItem("Ebac/Teste2 %g")]
    public static void Test2()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.name = "MeuCubo";
    }
}
