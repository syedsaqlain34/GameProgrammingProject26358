using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject enemyBulletPrefab; 
    public float fireRate = 2f;         
    public Vector3 bulletScale = new Vector3(0.5f, 0.5f, 0.5f); 
    public float leftOffset = 0.5f;     
    public float rightOffset = 0.5f;    

    void Start()
    {
        InvokeRepeating("Shoot", 1f, fireRate);
    }

    void Shoot()
    {
        // Calculate the spawn positions for left and right sides
        Vector3 leftSpawnPosition = transform.position + Vector3.left * leftOffset;
        Vector3 rightSpawnPosition = transform.position + Vector3.right * rightOffset;

        // Instantiate a bullet on the left side
        GameObject leftBullet = Instantiate(enemyBulletPrefab, leftSpawnPosition, Quaternion.identity);
        leftBullet.transform.localScale = bulletScale;

        // Instantiate a bullet on the right side
        GameObject rightBullet = Instantiate(enemyBulletPrefab, rightSpawnPosition, Quaternion.identity);
        rightBullet.transform.localScale = bulletScale;
    }
}
