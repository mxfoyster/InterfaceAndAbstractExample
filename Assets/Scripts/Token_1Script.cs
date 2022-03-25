using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token_1Script : AbstractTargetStuff
{
    [SerializeField] private GameObject token;

    public override void Start()
    {
        base.Start();
        token.transform.position = targetPosition;
    }

    public override void move()
    {
        token.transform.Rotate(0, 1.5f, 0);
    }
}
