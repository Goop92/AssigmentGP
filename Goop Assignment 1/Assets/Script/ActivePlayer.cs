using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayer : MonoBehaviour
{
    private ActivePlayerManger manager;
    public void AssignManager(ActivePlayerManger theManager)
    {
        manager = theManager;
    }

    public void FireProjectile()
    {
        manager.ChangeTurn();
    }
}
