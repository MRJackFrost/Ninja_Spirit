using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    public string nome;
    public string scenename;
    public string whatPortal;
    void Start()
    {
        scenename = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (whatPortal == "portal1")
            {
                GameManager.Instance.portal1 = true;
                GameManager.Instance.portal2 = false;
                GameManager.Instance.portal3 = false;
                GameManager.Instance.portal4 = false;
            }else if (whatPortal == "portal2")
            {
                GameManager.Instance.portal1 = false;
                GameManager.Instance.portal2 = true;
                GameManager.Instance.portal3 = false;
                GameManager.Instance.portal4 = false;
            }else if (whatPortal == "portal3")
            {
                GameManager.Instance.portal1 = false;
                GameManager.Instance.portal2 = false;
                GameManager.Instance.portal3 = true;
                GameManager.Instance.portal4 = false;
            }
            else if(whatPortal == "portal4")
            {
                GameManager.Instance.portal1 = false;
                GameManager.Instance.portal2 = false;
                GameManager.Instance.portal3 = false;
                GameManager.Instance.portal4 = true;
            }

            SceneManager.LoadScene(nome);
        }
    }
}
