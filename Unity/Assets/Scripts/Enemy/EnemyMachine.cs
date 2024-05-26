using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum EnumEnemyState
{
    RECUAR,
    PROCURAR,
    PERSEGUIR,
    SEGUIR,
    FUGIR
}

public class EnemyMachine : MonoBehaviour
{
    // Start is called before the first frame update
    public EnumEnemyState state;

    public Wander wander;
    public Seek seek;

    public bool item;

    public LayerMask player;

    void Start()
    {
        state = EnumEnemyState.PROCURAR;
        ChangeState(EnumEnemyState.PROCURAR);
    }

    void Update()
    {
        
        switch (state)
        {
            case EnumEnemyState.PROCURAR:
       
                var collider = Physics2D.OverlapCircle(transform.position, 4, player);
                if (collider.CompareTag("Player"))
                {
                    ChangeState(EnumEnemyState.PERSEGUIR);
                    
                }
                break;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 2);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
   

        if (other.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.Instance.life -= 1;
        }
    }

    public void ChangeState(EnumEnemyState newState)
    {
        switch (newState)
        {
            case EnumEnemyState.PROCURAR:
                DisableAll();
                wander.enabled = true;
                print("Procurando");
                break;

            case EnumEnemyState.PERSEGUIR:
                DisableAll();
                seek.enabled = true;
                print("Perseguindo");
                break;

        }

        state = newState;
    }

    private void DisableAll()
    {
        wander.enabled = false;
        seek.enabled = false;
    }


}

