using UnityEngine;
using System.Collections;

public class ObstacleManager : MonoBehaviour {

	public GameObject[] ObstaclePrefabs;
	public float[] ObstacleSpawnPercentages;
	public float spawnDistanceMin;
	public float spawnDistanceMax;
	public float spawnDistanceReducer;
	public float spawnFinalMin;
	public float spawnFinalMax;
	public float spawnHalfWidth;
	public float spawnHalfHeight;
	public float levelDistance;
	
	// Use this for initialization
	void Start () {
		
		// get sum 
		float sum = 0;
		for(int i=0; i < ObstacleSpawnPercentages.Length; i++)
		{
			sum += ObstacleSpawnPercentages[i];
		}
		// normalize percentages to 0-1
		for(int i=0; i < ObstacleSpawnPercentages.Length; i++)
		{
			ObstacleSpawnPercentages[i] = ObstacleSpawnPercentages[i]/sum;
		}
		
		// spawn objects at distance intervals
		float currDist = 0;
		do
		{
			currDist += Random.Range(spawnDistanceMin, spawnDistanceMax);
			SpawnRandWeightedObstacle(currDist);
			
			// reduce the min & max
			spawnDistanceMin -= spawnDistanceReducer;
			if(spawnDistanceMin < spawnFinalMin)
			{
				spawnDistanceMin = spawnFinalMin;
			}
			spawnDistanceMax -= spawnDistanceReducer;
			if(spawnDistanceMax < spawnFinalMax)
			{
				spawnDistanceMax = spawnFinalMax;
			}
			
		}while(currDist < levelDistance);
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	private GameObject SpawnRandWeightedObstacle(float y)
	{
		float rand = Random.value;
		int index=0;
		float sumPercent = 0;
		for(; index < ObstacleSpawnPercentages.Length-1; index++)
		{
			sumPercent += ObstacleSpawnPercentages[index]; 
			if(sumPercent >= rand)
			{
				break;
			}
		}
		
		//Debug.Log("-- rand:"+rand+" sumPercent"+sumPercent+" index:"+index);
		
		GameObject obstacleGob = ObjectPool.instance.GetObjectForType(ObstaclePrefabs[index].name, true);
		if(obstacleGob)
		{
			Debug.Log("spawned obstacle at "+y);
			
			obstacleGob.BroadcastMessage("ObstacleSpawned", null, SendMessageOptions.DontRequireReceiver);
			obstacleGob.transform.localRotation = Quaternion.identity;
			// obstacleGob.transform.localScale = Vector3(1,1,1);
			obstacleGob.transform.localPosition = new Vector3(
				Random.Range(-spawnHalfWidth, spawnHalfWidth),
				y,
				Random.Range(-spawnHalfHeight, spawnHalfHeight)
				);
		}
		
		return obstacleGob;
	}
}
