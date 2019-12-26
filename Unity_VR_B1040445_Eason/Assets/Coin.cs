using UnityEngine;

public class Coin : MonoBehaviour
{
    public int speed;

    private void Update()
    {
        transform.Rotate(0,0,speed * Time.deltaTime);
    }
}
