using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    Player player;


    private void Awake()
    {
        //Game Manager in world, destory
        if (instance != null)
        {
            Destroy(instance.gameObject);
        }
        else
        {
            instance = this;
        }

        
    }

    private void Start()
    {
  
     


    }

    public void CompleteMove()
    {
        GameManager.instance.EndTurn();
    }
}
