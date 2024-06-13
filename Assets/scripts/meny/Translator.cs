using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Translator : MonoBehaviour
{
    private TextMeshProUGUI txt;
    public string[] variants;
    private void Start()
    {
        txt = GetComponent<TextMeshProUGUI>();
    }
    void FixedUpdate()
    {
        txt.text = variants[GeneralInfo.language];
    }
}
public static class GeneralInfo
{
    public static byte language = 1;//0 - ru, 1 - en
}