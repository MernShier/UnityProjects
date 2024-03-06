using System.Collections;
using Jobs;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

public class Mover : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float speed;
    [SerializeField] private int objectCount;
    [SerializeField] private float waitSeconds;

    private Transform[] _objectsOnScene;
    private TransformAccessArray _transformOnScene;

    private void Start()
    {
        _objectsOnScene = new Transform[objectCount];
        for (int i = 0; i < objectCount; i++)
        {
            GameObject instance = 
                Instantiate(prefab, new Vector3(Random.Range(-100, 101), 1f, Random.Range(-100, 101)), Quaternion.identity);
            _objectsOnScene[i] = instance.transform;
        }

        _transformOnScene = new TransformAccessArray(_objectsOnScene);
        StartCoroutine(DoLogs());
    }

    private void Update()
    {
        var moveJob = new MoveJob
        {
            Speed = speed,
        };
        JobHandle movementJobHandel = moveJob.Schedule(_transformOnScene);
        movementJobHandel.Complete();
    }

    private void OnDestroy()
    {
        _transformOnScene.Dispose();
    }

    private IEnumerator DoLogs()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitSeconds);

            NativeArray<int> numbers = new NativeArray<int>(_objectsOnScene.Length, Allocator.Persistent);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Random.Range(1, 101);
            }

            LogJob logJob = new LogJob()
            {
                Numbers = numbers
            };

            JobHandle logJobHandel = logJob.Schedule();
            logJobHandel.Complete();

            numbers.Dispose();
        }
    }
}