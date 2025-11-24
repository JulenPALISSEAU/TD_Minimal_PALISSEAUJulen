
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using static UnityEngine.Rendering.DebugUI;
using Unity.VisualScripting;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] GameObject Prefab_Circle;
    [SerializeField] GameObject Prefab_Square;
    

    List<GameObject> ListEnemy;

    private void Start()
    {
        WaveControl();









    }

    IEnumerator WaveControl()
    {
        for (int j = 0; j < 5; j++)
        {
            Wave();
            yield return new WaitForSeconds(5f);
        }
    }
    IEnumerator Wave()
    {
        for (int i=0; i<3; i++)
        {
            if (Random.Range(0f, 1f) > .5f)
            {
                if (Prefab_Circle) {
                    GameObject temp = Instantiate(Prefab_Circle, transform.position, Quaternion.identity);
                    ListEnemy.Add(temp);
                }
            }
            else
            {
                if (Prefab_Square) {
                    GameObject temp = Instantiate(Prefab_Square, transform.position, Quaternion.identity);
                    ListEnemy.Add(temp);
                }
            }
            yield return new WaitForSeconds(2f);
        }
        yield return new WaitUntil(ListEnemy == null);
    }
}
