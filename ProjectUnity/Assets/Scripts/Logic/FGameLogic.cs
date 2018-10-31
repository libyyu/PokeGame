
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FGame
{
    public class FGameLogic : MonoBehaviour
    {
        void Awake()
        {

        }
    }

    public class FGameApp
    {
        static FGameLogic FGo;
        FGameLogic FGO
        {
            get
            {
                if(null == FGo)
                {
                    GameObject go = new GameObject("FGameLogic");
                    FGo = go.AddComponent<FGameLogic>();
                }
                return FGo;
            }
        }

        void Run()
        {

        }
    }
}
