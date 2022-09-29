using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ActivePlayerManger : MonoBehaviour
{
    [SerializeField] private ActivePlayer Player1;
    [SerializeField] private ActivePlayer Player2;
    [SerializeField] public CinemachineFreeLook Player1Camera;
    [SerializeField] public CinemachineFreeLook Player2Camera;

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
            Player1Camera.Priority = 0;
            Player2Camera.Priority = 1;
            currentPlayer = Player2;
            Debug.Log("Player" + currentPlayer);
        }
        else if (Player2 == currentPlayer)
        {
            Player1Camera.Priority = 1;
            Player2Camera.Priority = 0;
            currentPlayer = Player1;
            Debug.Log("Player" + currentPlayer);
        }

    }


}
