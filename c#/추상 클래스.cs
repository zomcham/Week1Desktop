using UnityEngine;

public abstract class Enity
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity target);
    public void TakeDamage(int damage)
    {
        if(currentHP>damage){
            currentHP-=damage;
            Debug.Log9($"체력이 {damage}감소");
        }
        else{
            Debug.Log("Die");
        }
    }
}