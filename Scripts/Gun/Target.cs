using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            SumScore.Add( pointsToAdd: 1);
            Die();
            
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
