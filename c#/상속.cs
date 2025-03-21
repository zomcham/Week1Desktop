using UnityEngine;

public class Entity
{
    public string ID;
    protected int currentHP;

    private void initallize()
    {
        ID="Noname";
    }

    public void RecoveryHP(int Hp)
    {
        curremtHP+=Hp;
    }
}

public class Player:Entity
{
    public Player(string id,int hp)
    {
        ID=id;
        currentHP=hp;

        RecoveryHP(1000);
    }
}