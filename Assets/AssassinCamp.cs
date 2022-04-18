using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssassinCamp : Camp
{
    public GameObject assassin;
    public override void Build()
    {
        assassin = Object.Instantiate(Resources.Load("assassin") as GameObject);
    }
}

