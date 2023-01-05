using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
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
        p.x += 0.01f;
        transform.position = p;

        // Find my Sphere and create a new component
        GameObject g = GameObject.Find("Sphere");
        MoveX m = g.GetComponent<MoveX>();
        if (m == null)
        {
            g.AddComponent<MoveX>();
        }
    }
}

