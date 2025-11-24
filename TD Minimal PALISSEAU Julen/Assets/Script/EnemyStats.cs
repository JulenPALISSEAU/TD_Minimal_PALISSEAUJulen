using UnityEngine;
public class EnemyStats : MonoBehaviour
{
    public int ID;
    public int HP;
    public int Vitesse;
    public int AttackSpeed;
    public int AttackPower;
    public int Damage;
    public int Defense;

    void Start()
    {
        ID = 0;
        HP = 0;
        Vitesse = 0;
        AttackSpeed = 0;
        AttackPower = 0;
        Damage = 0;
        Defense = 0;
    }
}