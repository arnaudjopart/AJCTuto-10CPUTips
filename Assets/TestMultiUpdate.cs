using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMultiUpdate : MonoBehaviour
{
    [SerializeField] private GameObject m_prefab;
    public int m_lines;
    public int m_columns;

    public bool m_singleUpdateMethod;

    public SmallUpdate[] m_instances;

    private int m_nbInstances;

    // Start is called before the first frame update
    void Start()
    {
        m_nbInstances = m_lines * m_columns;
        m_instances = new SmallUpdate[m_lines * m_columns];
        for (var i = 0; i < m_lines; i++)
        {
            for (var j = 0; j < m_columns; j++)
            {
                var instanceGameObject = Instantiate(m_prefab, new Vector3(i * 1.5f, 0, j * 1.5f), Quaternion.identity);
                m_instances[i*m_columns + j] = instanceGameObject.GetComponent<SmallUpdate>();
                //m_instances[i * m_columns + j].ActivateUpdate(m_singleUpdateMethod);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_singleUpdateMethod) return;
        for (var i = 0; i < m_nbInstances; i++)
        {
            m_instances[i].DoRotate();
        }
    }
}
