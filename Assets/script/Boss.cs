using UnityEngine;

public class Boss : MonoBehaviour
{
    public int health = 100;
    public void damage()
    {
        health -= 10;
        if( health < 1)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.CompareTag("Bullet"))
        {
            damage();
        }
        if (collision.gameObject.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player>().bossAttacked();
        }
    }
}
