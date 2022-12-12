using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class OrderOfOperations : MonoBehaviour
{
    [SerializeField] private int m_nbOfOperations;

    private Vector3 m_vector;

    private float m_myFloat1;
    private float m_myFloat2;

    // Start is called before the first frame update
    void Start()
    {
        VxFxF();
        FxFxV();
        FxVxF();
    }

    private void VxFxF()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        for (var i = 0; i < m_nbOfOperations; i++)
        {
            m_vector += m_vector* m_myFloat1 * m_myFloat2;
        }
        stopWatch.Stop();
        Debug.Log("VxFxF :"+stopWatch.Elapsed.Milliseconds);
    }

    private void FxFxV()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        for (var i = 0; i < m_nbOfOperations; i++)
        {
            m_vector += m_myFloat1 * m_myFloat2* m_vector;
        }
        stopWatch.Stop();
        Debug.Log("FxFxV :"+stopWatch.Elapsed.Milliseconds);
    }
    
    private void FxVxF()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        for (var i = 0; i < m_nbOfOperations; i++)
        {
            m_vector += m_myFloat1 * m_vector * m_myFloat2;
        }
        stopWatch.Stop();
        Debug.Log("FxVxF :"+stopWatch.Elapsed.Milliseconds);
    }
}
