using UnityEngine;

public class ComponentBenchMark : MonoBehaviour
{
    private AudioListener m_myComponentInCache;
    private const int Iterations = 500000;
    [SerializeField] private bool m_useCachedComponent;

    private void Start()
    {
        m_myComponentInCache = GetComponent<AudioListener>();
    }
    private void Update()
    {
        if (!m_useCachedComponent) TestGetComponent();
        else TestCachedComponent();
    }
    private void TestGetComponent()
    {
        for (var i = 0; i < Iterations; i++) GetComponent<AudioListener>().enabled = false;
    }
    private void TestCachedComponent()
    {
        for (var i = 0; i < Iterations; i++) m_myComponentInCache.enabled = false;
    }
}
