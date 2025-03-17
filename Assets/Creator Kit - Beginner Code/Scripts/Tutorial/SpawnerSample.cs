using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    LootAngle myLootAngle = new LootAngle(45);

    void Start()
    {
        //every call will advance the angle!
        PotionSpawner(myLootAngle.NextAngle());
        PotionSpawner(myLootAngle.NextAngle());
        PotionSpawner(myLootAngle.NextAngle());
        PotionSpawner(myLootAngle.NextAngle());

        // PotionSpawner(0);
        // PotionSpawner(45);
        // PotionSpawner(90);
        // PotionSpawner(135);

        // int angle = 15;
        // int radius = 5;
        // Vector3 spawnPosition = transform.position;

        // Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        // spawnPosition = transform.position + direction * radius;
        // Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        // angle = 55;
        // direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        // spawnPosition = transform.position + direction * radius;
        // Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        // angle = 95;
        // direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        // spawnPosition = transform.position + direction * radius;
        // Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        // angle = 105;
        // direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        // spawnPosition = transform.position + direction * radius;
        // Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }

    void PotionSpawner(int angle) 
    {
        int radius = 5;

        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

public class LootAngle 
{
    int angle; 
    int step; 

    public LootAngle(int increment)
    { 
        step = increment;
        angle = 0;
    }

    public int NextAngle() 
    {
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);

        return currentAngle;
    }
}

