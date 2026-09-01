using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OOPExit : Identity
{
    public GameObject Canvas;

    public override void Hit()
    {
        base.Hit();
        Canvas.SetActive(true);
    }

}
