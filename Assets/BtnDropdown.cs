using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BtnDropdown : MonoBehaviour
{
    public Button MainBtn;
    public GameObject BtnPanel;
    private bool isVisiblePanel = false;

    public void ChangeVisibility()
    {
        isVisiblePanel = !isVisiblePanel;
        BtnPanel.SetActive(isVisiblePanel);
    }
    
}
