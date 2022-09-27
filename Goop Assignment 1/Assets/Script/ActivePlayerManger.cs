using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerManger : MonoBehaviour
{
    [SerializeField] private ActivePlayer Player1;
    [SerializeField] private ActivePlayer Player2;

    private ActivePlayer currentPlayer;
    void Start() 
    {
        Player1.AssignManager(this);
        Player2.AssignManager(this);

        currentPlayer = Player1;
    }

public ActivePlayer GetCurrentPlayer()
    {
        return currentPlayer;
    }
    public void ChangeTurn()
    {
        if (Player1 == currentPlayer)
        {
            currentPlayer = Player2;
            Debug.Log("Player" + currentPlayer);
        }
        else if (Player2 == currentPlayer)
        {
            currentPlayer = Player1;
            Debug.Log("Player" + currentPlayer);

        }
    }

}
