using UnityEngine;

public class Player
{
    private int currentHP;
    public int CurrentHP;
    {
        get => currentHP;
        set
        {
            if(currentHP>0){
                currentHP=value;
            }
            else{
                currentHP=0;
            }
        }
    }
}

public class GameController
{
    private void Awake()
    {
        Player player=new Player();
        player.CurrentHP=100;
        Debug.Log($"Player HP:(player.CurrentHP)");
        player.CurrentHP=-100;
        Debug.Log($"Player HP:(player.CurrentHP)");
    }
}