using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public static PanelManager instance;
    public Login loginPanel;
    public Home homePanel;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (User.instance.logedIn)
            GoHome();
    }

    public void GoHome()
    {
        loginPanel.gameObject.SetActive(false);
        homePanel.gameObject.SetActive(true);
    }

    public void GoLogin()
    {
        loginPanel.gameObject.SetActive(true);
        homePanel.gameObject.SetActive(false);
    }
}
