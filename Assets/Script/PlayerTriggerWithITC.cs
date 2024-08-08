using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Samarnggoon.GameDev3.Chapter1;
using Samarnggoon.GameDev3.Chapter3;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Samarnggoon.GameDev3.Chapter4
{
    public class PlayerTriggerWithITC : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            //Get components from item object
//Get the ItemTypeComponent component from the triggered object
            ItemTypeComponent itc = other.GetComponent<ItemTypeComponent>();
//Get components from the player
//Inventory
            var inventory = GetComponent<Inventory>();
//SimpleHealthPointComponent
            var simpleHP = GetComponent<SimpleHealthPointComponent>();
            if (itc != null)
            {
                switch (itc.Type)
                {
                    case ItemType.COIN:
                        inventory.AddItem("COIN",1);
                        break;
                    case ItemType.BIGCOIN:
                        inventory.AddItem("BIGCOIN",1);
                        break;
                    case ItemType.POWERUP:
                        if (simpleHP != null)
                            simpleHP.HealthPoint += 10;
                        break;
                    case ItemType.POWERDOWN:
                        if (simpleHP != null)
                            simpleHP.HealthPoint -= 10;
                        break;
                    case ItemType.SPEEDUP:
                        CapsulePlayerController.ChangeSpeed(10);
                        break;
                    case ItemType.CONSOLEDEBUG:
                        Debug.Log("This is Console Debug");
                        break;
                }
            }

            Destroy(other.gameObject, 0);
        }
    }
}
