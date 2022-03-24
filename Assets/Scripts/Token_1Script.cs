using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token_1Script : MonoBehaviour, IMovingTarget
{
    [SerializeField] private GameObject token;
    
   
    public void move()
    {
        token.transform.Rotate(0, 1.5f, 0);
    }
}
