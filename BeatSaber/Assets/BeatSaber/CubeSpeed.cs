using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CubeSpeed", menuName = "CubeSpeed")]
public class CubeSpeed : ScriptableObject
{

    [SerializeField] private float speed;

    public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }
}
