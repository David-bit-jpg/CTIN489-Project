using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.Rendering.Universal;
public class BalloonSpawnerBad : MonoBehaviour
{
    [Header("Balloons")]
    [SerializeField] private GameObject redBalloon;
    [SerializeField] private GameObject pinkBalloon;
    [SerializeField] private GameObject yellowBalloon;
    [SerializeField] public float xMin = -27.0f, xMax = 27.0f;
    [SerializeField] public float zMin = -27.0f, zMax = 27.0f;
    [SerializeField] private GameObject ghostPrefab;
    [SerializeField] private Text warningText;
    [SerializeField] private int spawnNumLong = 8;
    [SerializeField] private int spawnNumShort = 3;
    public float raycastDistance = 50.0f;
    public float safeDistance = 0.4f;
    PlayerMovement mPlayer;
    bool textStarted = false;

    private List<GameObject> spawnedBalloons = new List<GameObject>();
    void Start()
    {
        warningText.gameObject.SetActive(false);
        mPlayer = FindObjectOfType<PlayerMovement>();
        StartCoroutine(SpawnBalloonWithIntervalShort());
        StartCoroutine(SpawnBalloonWithIntervalLong());
    }
    void Update()
    {
        if (CheckForBreakedBalloons())
        {
            SpawnGhostNearPlayer();
        }
    }
    void SpawnGhostNearPlayer()
    {
        TriggerTextAnimation();
        Vector3 playerForward = mPlayer.transform.forward;
        Vector3 playerRight = mPlayer.transform.right;

        float angle = Random.Range(-180, 180);
        Vector3 randomDirection = Quaternion.Euler(0, angle, 0) * playerForward * Random.Range(2.0f, 6.0f);

        if (angle > -45 && angle < 45)
        {
            randomDirection += playerRight * 6.0f;
        }

        Vector3 targetPosition = mPlayer.transform.position + randomDirection;
        NavMeshHit hit;
        if (NavMesh.SamplePosition(targetPosition, out hit, 6.0f, NavMesh.AllAreas))
        {
            Instantiate(ghostPrefab, hit.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("Failed to find a valid position for the ghost on NavMesh.");
        }
    }

    private IEnumerator SpawnBalloonWithIntervalLong()
    {
        yield return new WaitForSeconds(Random.Range(15f, 25f));
        if (spawnedBalloons.Count <= spawnNumLong)
        {
            SpawnRandomBalloon();
        }
        StartCoroutine(SpawnBalloonWithIntervalLong());
    }
    private IEnumerator SpawnBalloonWithIntervalShort()
    {
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        if (spawnedBalloons.Count <= spawnNumShort)
        {
            SpawnRandomBalloon();
        }
        StartCoroutine(SpawnBalloonWithIntervalShort());
    }
    private void SpawnRandomBalloon()
    {
        GameObject[] balloons = new GameObject[] { redBalloon, pinkBalloon, yellowBalloon };
        int index = Random.Range(0, balloons.Length);
        Vector3 spawnPosition = Vector3.zero;
        bool validPositionFound = false;

        int maxAttempts = 10;
        for (int i = 0; i < maxAttempts; i++)
        {
            float randomX = Random.Range(xMin, xMax);
            float randomZ = Random.Range(zMin, zMax);
            spawnPosition = new Vector3(randomX, 1, randomZ);
            Collider[] colliders = Physics.OverlapSphere(spawnPosition, safeDistance);

            if (colliders.Length == 0)
            {
                validPositionFound = true;
                break;
            }
        }

        if (validPositionFound)
        {
            GameObject spawnedBalloon = Instantiate(balloons[index], spawnPosition, Quaternion.identity);
            spawnedBalloons.Add(spawnedBalloon);
        }
        else
        {
            Debug.Log("Failed to find a valid spawn position for the balloon.");
        }
    }
    bool CheckForBreakedBalloons()
    {
        foreach (GameObject b in new List<GameObject>(spawnedBalloons))
        {
            Break_Ghost balloonScript = b.GetComponent<Break_Ghost>();
            if (balloonScript != null && balloonScript.Is_Breaked)
            {
                spawnedBalloons.Remove(b);
                return true;
            }
        }
        return false;
    }
    public void TriggerTextAnimation()
    {
        if(!textStarted)
        {
            StartCoroutine(AnimateText());
        }
    }

    private IEnumerator AnimateText()
    {
        textStarted = true;
        float duration = 2.0f;
        float holdTime = 1.0f;
        float startSize = 0f;
        float endSize = 60f;
        warningText.gameObject.SetActive(true);
        for (float timer = 0; timer < duration; timer += Time.deltaTime)
        {
            float progress = timer / duration;
            warningText.fontSize = (int)Mathf.Lerp(startSize, endSize, progress);
            yield return null;
        }
        warningText.fontSize = (int)endSize;
        yield return new WaitForSeconds(holdTime);
        warningText.fontSize = (int)startSize;
        warningText.gameObject.SetActive(false);
        textStarted = false;
    }
}
