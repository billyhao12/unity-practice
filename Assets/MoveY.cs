using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveY : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake on: " + gameObject.name);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start on: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = transform.position;
        p.x += 0.0001f;
        transform.position = p;

        GameObject g = GameObject.Find("Cube");
        MoveX m = g.GetComponent<MoveX>();
        if (m != null)
        {
            m.dDelta(-0.001f);
        }
    }
}

