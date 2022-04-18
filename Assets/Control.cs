using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject sword;
    public GameObject axe;
    public GameObject archer;
    public GameObject assassin;
    public GameObject title1;
    public GameObject title2;
    public GameObject title3;
    public GameObject title4;
    public GameObject name1;
    public GameObject name2;
    public GameObject name3;
    public GameObject name4;

    // Update is called once per frame
    void Update()
    {
        sword = GameObject.Find("sword(Clone)");
        axe = GameObject.Find("axe(Clone)");
        archer = GameObject.Find("archer(Clone)");
        assassin = GameObject.Find("assassin(Clone)");
        title1 = GameObject.Find("title1(Clone)");
        title2 = GameObject.Find("title2(Clone)");
        title3 = GameObject.Find("title3(Clone)");
        title4 = GameObject.Find("title4(Clone)");
        name1 = GameObject.Find("name1(Clone)");
        name2 = GameObject.Find("name2(Clone)");
        name3 = GameObject.Find("name3(Clone)");
        name4 = GameObject.Find("name4(Clone)");

        if (sword != null)
        {
            title1.transform.position = sword.transform.position + new Vector3(-15, 20, 0);
            name1.transform.position = sword.transform.position + new Vector3(30, 20, 0);
        }
        if (axe != null)
        {
            title2.transform.position = axe.transform.position + new Vector3(-15, 20, 0);
            name2.transform.position = axe.transform.position + new Vector3(30, 20, 0);
        }
        if (archer != null)
        {
            title3.transform.position = archer.transform.position + new Vector3(-15, 20, 0);
            name3.transform.position = archer.transform.position + new Vector3(30, 20, 0);
        }
        if (assassin != null)
        {
            title4.transform.position = assassin.transform.position + new Vector3(-15, 20, 0);
            name4.transform.position = assassin.transform.position + new Vector3(30, 20, 0);
        }
    }
}
