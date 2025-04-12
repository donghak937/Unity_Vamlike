using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerMovement player; 
    public static GameManager instance; //안나타남남

    void Awake()
    {
        instance = this;
    }
}
