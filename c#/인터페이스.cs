using UnityEngine;

interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}

public class Slime:IMovingEntity
{
    public void MoveTo(Vector3 destinatin)
    {
        Debug.Log($"(destination)까지 기어서 이동");
    }
}