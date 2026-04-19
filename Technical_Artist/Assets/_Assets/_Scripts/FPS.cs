using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class FPS : MonoBehaviour
{
    private float currentfps;
    private float Avgfps;

    private TextMeshProUGUI m_TextMeshProUGUI;

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 65;
    }

    private void Start()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();

    }

  
    private void Update()
    {
        currentfps = Time.frameCount / Time.time; 
        Avgfps = (int)currentfps;

        m_TextMeshProUGUI.text = Avgfps.ToString();
    }
}
