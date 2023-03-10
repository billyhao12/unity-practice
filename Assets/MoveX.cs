using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
{
    float mDelta = 0.01f;

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
        p.x += mDelta;
        transform.position = p;
    }

    public void dDelta(float d)
    {
        mDelta += d;
    }
}

