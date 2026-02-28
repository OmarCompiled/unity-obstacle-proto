using System;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    enum Axes
    {
        X,
        Y,
        Z,
    }

    [SerializeField]
    Axes axisOption = Axes.Y;

    private Vector3 axis;

    void Update()
    {
        axis = GetAxis(axisOption);
        transform.Rotate(axis, 0.3f);
    }

    Vector3 GetAxis(Axes axisOption)
    {
        switch(axisOption)
        {
            case Axes.X: return Vector3.right;
            case Axes.Y: return Vector3.up;
            case Axes.Z: return Vector3.forward;
            default: return Vector3.up;
        }
    }
}
