using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivePlayerShoot : MonoBehaviour
{
    [SerializeField] private ActivePlayerManger manager;
    [SerializeField] private Button botton;
    // Start is called before the first frame update
    void Start()
    {
        botton.onClick.AddListener(ButtonPressed);
    }

    public void ButtonPressed()
    {
        ActivePlayer currentPlayer = manager.GetCurrentPlayer();
        currentPlayer.FireProjectile();
    }
}
