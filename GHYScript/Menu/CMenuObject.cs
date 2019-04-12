﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CMenuObject : MonoBehaviour
{
    public static CMenuObject mo;
    // Use this for initialization
    public GameObject[] m_MenuList = new GameObject[7];
    public GameObject m_Menu;
    public GameObject m_Dlg;
    public GameObject m_HitDlg;
    public Text m_HitDlgText;
    public GameObject m_MenuButton;
    public GameObject m_BagUI;
    public GameObject m_BattleUI;
    public Text m_ButtonMsg;

    //public GameObject BasicText;

    private void Awake()
    {
        if (mo == null)
        {
            DontDestroyOnLoad(gameObject);
            mo = this;
        }
        else if (mo != null)
        {
            Destroy(gameObject);
        }
    }
    

    void Start()
    {
        DontDestroyOnLoad(m_Menu);
        DontDestroyOnLoad(m_Dlg);
        DontDestroyOnLoad(m_HitDlg);
        for(int i = 0;i < m_MenuList.Length; i++)
        {
            DontDestroyOnLoad(m_MenuList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
