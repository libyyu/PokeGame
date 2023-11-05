using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTest : MonoBehaviour
{
    private string pathChat;
    private string pathScroll;

    private void Awake()
    {
        pathScroll = "UpToDown/UIMainDiscover";
        pathChat = "Perfabs/ChatRoom";
        Transform uiTf = GameObject.FindGameObjectWithTag("UiRoot").transform;
        GameObject obj = Instantiate(Resources.Load<GameObject>(pathScroll), uiTf);
    }
}
