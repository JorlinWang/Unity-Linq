using System.Linq;
using UnityEngine;
/// <summary>
/// 对序列中的元素进行分组。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.groupby?view=netframework-4.6.1
/// </summary>
public class GroupBy : MonoBehaviour
{
	class Pet
	{
		public string Name;
		public float Age;

	}
	// Use this for initialization
	void Start()
	{
		Pet[] pets = {
			new Pet{ Name = "a", Age = 1},
			new Pet{ Name = "a", Age = 1.2f},
			new Pet{ Name = "b", Age = 2.2f},
			new Pet{ Name = "a", Age = 1.6f},
			new Pet{ Name = "c", Age = 3},
			new Pet{ Name = "a", Age = 3.1f},
		};
		var query = pets.GroupBy(
			pet => Mathf.Floor(pet.Age),
			pet => pet,
			(key, value) =>
			{
				return new { key = key, pet = value };
			}
			);
		foreach (var perGroup in query)
		{
			Debug.Log("Group of " + perGroup.key + "********************");
			foreach (var pet in perGroup.pet)
				Debug.LogFormat("name: {0}, age: {1}", pet.Name, pet.Age);
		}
		Pet[] pets2 = {
			new Pet{ Name = "a", Age = 1},
			new Pet{ Name = "a", Age = 1f},
			new Pet{ Name = "b", Age = 2f},
			new Pet{ Name = "a", Age = 1f},
			new Pet{ Name = "c", Age = 3},
			new Pet{ Name = "a", Age = 3f},
		};
		var query2 = pets2.GroupBy(
			pet => pet.Age,
			pet => pet.Name
			);
		foreach (var perGroup in query2)
		{
			Debug.Log("Group key: " + perGroup.Key);
			foreach (var pet in perGroup)
				Debug.Log(pet);
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}
