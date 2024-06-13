using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLanguage : MonoBehaviour
{
    public byte language = 0;
    public void Set()
    {
        GeneralInfo.language = language;
    }
}
