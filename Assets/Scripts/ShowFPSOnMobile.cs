using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowFPSOnMobile : MonoBehaviour
{
    TextMeshProUGUI fpsText;
    float deltaTime;
    private void Start()
    {
        fpsText = GetComponent<TextMeshProUGUI>();
        if(!(Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer))
        {
            this.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        fpsText.text = string.Format("{0:0.} fps", fps);
    }
}
