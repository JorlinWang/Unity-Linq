using System.Linq;
using UnityEngine;
/// <summary>
/// 生成两个序列的交集。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.intersect?view=netframework-4.6.1
/// </summary>
public class Intersect : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] id1 = { 1, 2, 3, 4, 5, 6 };
		int[] id2 = { 1, 4 };
		var query = id1.Intersect(id2);
		foreach (var id in query)
			Debug.Log(id);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
