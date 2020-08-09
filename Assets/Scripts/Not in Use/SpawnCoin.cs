using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
	public GameObject CoinPrefab;
    public GameObject ContainerPrefab;
    public int numcoins;

	public Vector3 center;
	public Vector3 size;
    public Vector3 scale;
    public Vector3 rotation;

	// Start is called before the first frame update
	void Start()
	{
		for (int i = 0; i < numcoins; i++)
		{
			CoinSpawner();
		}
	}

	public void CoinSpawner()
	{
		Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0, Random.Range(-size.z / 2, size.z / 2));

		GameObject coin = Instantiate(CoinPrefab, pos, Quaternion.identity);
        coin.transform.localScale = scale;
        coin.transform.Rotate(rotation, Space.Self);
        coin.transform.position = new Vector3(pos.x - 0.02694f, 0.18f, pos.z - 0.33829f);
        GameObject container = Instantiate(ContainerPrefab, pos, Quaternion.identity);
    }
}
