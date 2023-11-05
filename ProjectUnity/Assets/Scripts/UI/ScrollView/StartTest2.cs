using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTest2 : MonoBehaviour
{
    private string pathChat;
    private string pathScroll;

    private void Awake()
    {
        pathScroll = "UpToDown/UIMainDiscover";
        pathChat = "Perfabs/ChatRoom";
        GameObject obj = Instantiate(Resources.Load<GameObject>(pathChat), transform);
    }
}
