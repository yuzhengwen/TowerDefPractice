using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    public static Vector2 getMousePos2D()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
