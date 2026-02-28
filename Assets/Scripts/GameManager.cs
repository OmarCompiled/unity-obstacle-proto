using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get{return instance;}
        private set{instance = value;}
    }

    private static int collisions = 0;
    public static int Collisions
    {
        get{return collisions;}
        set{collisions = value;}
    }

    [SerializeField]
    PlayerUI playerUI;

    public GameObject projectileSpawner;

    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;
        collisions = 0;
    }

    void Update()
    {
        playerUI.UpdateCollisionDisplay(Collisions);
    }
}
