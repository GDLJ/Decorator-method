using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCamp :Camp
{
    public GameObject axe;
    public override void Build()
    {
        axe = Object.Instantiate(Resources.Load("axe") as GameObject);
    }
  
}
