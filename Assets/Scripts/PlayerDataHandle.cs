using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    public static PlayerDataHandle Instance;

    public string playerName;

    public int score;

    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
