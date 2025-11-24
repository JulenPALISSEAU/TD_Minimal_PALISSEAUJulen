using System.Collections;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public EnemyStats EnemyStats;
    void Start()
    {
        test();
        if (EnemyStats.ID == 1)
        {

        }
        else
        {

        }
    }

    void Update()
    {
        
    }


    IEnumerator test()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
