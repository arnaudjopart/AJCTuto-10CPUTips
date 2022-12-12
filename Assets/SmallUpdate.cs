using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallUpdate : MonoBehaviour
{
    private Transform m_transform;

    // Start is called before the first frame update
    void Start()
    {
        m_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    /*void Update()
    {
        //DoRotate();
    }*/

    public void DoRotate()
    {
        m_transform.rotation *= Quaternion.Euler(0, 60 * Time.deltaTime, 0);
    }
}
