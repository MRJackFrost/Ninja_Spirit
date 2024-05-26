using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    
    public Sprite fulllife;
    public Sprite threelifes;
    public Sprite twolifes;
    public Sprite onelifes;
    public Sprite zerolifes;
    public Image life;
    public TMP_Text bananatext;

    public void Update()
    {
        Instance.ChangeLife();
        bananatext.text = GameManager.Instance.banana.ToString();
    }

    private void ChangeLife()
    {
        if (GameManager.Instance.life == 4)
        {
            life.sprite = fulllife;
        }else if (GameManager.Instance.life == 3)
        {
            life.sprite = threelifes;
        }
        else if (GameManager.Instance.life == 2)
        {
            life.sprite = twolifes;
        }else if (GameManager.Instance.life == 1)
        {
            life.sprite = onelifes;
        }
        else
        {
            life.sprite = zerolifes;
        }
    }
}
