using System;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class TestMainCamera : MonoBehaviour
{
    private Camera m_cachedCamera;
    [SerializeField] private int m_iterations;
    private float[] m_randomValues;

    private 
    // Start is called before the first frame update
    void Start()
    {
        m_cachedCamera = Camera.main;
        CreateRandom();
        
        UseCameraMain();
        UseCachedCamera();
       
    }
    private void UseCameraMain() 
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        for (var i = 0; i < m_iterations; i++)
        {
            Camera.main.gameObject.transform.position = new Vector3(m_randomValues[i],0,0);
        }
        stopWatch.Stop();
        Debug.Log("UseCameraMain : "+stopWatch.Elapsed.Milliseconds);
    }
    private void UseCachedCamera()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        for (var i = 0; i < m_iterations; i++)
        {
            m_cachedCamera.gameObject.transform.position = new Vector3(m_randomValues[i],0,0);
        }
        stopWatch.Stop();
        Debug.Log("UseCachedCamera : "+stopWatch.Elapsed.Milliseconds);
    }

    
    
    private void CreateRandom()
    {
        m_randomValues = new float[m_iterations];
        for (var i = 0; i < m_iterations; i++)
        {
            m_randomValues[i] = Random.Range(0, 100);
        }
    }

}
