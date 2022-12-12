using UnityEngine;

public class CompareTag : MonoBehaviour
{
    [SerializeField] private int m_iterations = 50000;
    public bool m_useCompareTag;
    
    void Update()
    {
        if(m_useCompareTag) UseCompareTag();
        else TagProperty();
    }

    private void TagProperty()
    {
        for (var i = 0; i < m_iterations; i++)
        {
            if (tag == Tags.PlayerTag)
            {
                //do something
            }
        }
    }
    private void UseCompareTag()
    {
        for (var i = 0; i < m_iterations; i++)
        {
            if (this.CompareTag(Tags.PlayerTag))
            {
                //do something
            }
        }
    }
}



public class Tags
{
    public const string PlayerTag = "Player";
}




