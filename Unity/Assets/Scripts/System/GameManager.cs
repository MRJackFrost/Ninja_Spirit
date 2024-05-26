using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;
    private GameObject player;
    public bool portal1;
    public bool portal2;
    public bool portal3;
    public bool portal4;
    
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public int life;
    public int banana = 0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
