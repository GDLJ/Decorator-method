using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClient : MonoBehaviour
{
    public Factory factory = new Factory();

    public void BuildSwordman()
    {
        factory.CreatCamp("sword");
    }
    public void BuildAxeman()
    {
        factory.CreatCamp("axe");
    }
    public void BuildArcher()
    {
        factory.CreatCamp("archer");
    }
    public void BuildAssassin()
    {
        factory.CreatCamp("assassin");
    }
}
