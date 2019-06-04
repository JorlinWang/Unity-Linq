using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// 通过使用指定的 IEqualityComparer<T> 确定序列是否包含指定的元素。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.contains?view=netframework-4.6.1
/// </summary>
public class Contains : MonoBehaviour
{
	class Pet : IEqualityComparer<Pet>
	{
		public string Name;
		public int Age;

		public bool Equals(Pet x, Pet y)
		{
			Debug.Log("asdfsdaf");
			return x.Name == y.Name && x.Age == y.Age;
		}


		public int GetHashCode(Pet obj)
		{
			return Name.GetHashCode();
		}
	}
	// Use this for initialization
	void Start()
	{
		Pet[] pets = {
			new Pet{ Name = "a", Age = 1},
			new Pet{ Name = "b", Age = 2},
			new Pet{ Name = "c", Age = 3},
		};
		var pet = new Pet { Name = "a", Age = 1 };
		Debug.Log(pets.Contains(pet, pet));
	}

	// Update is called once per frame
	void Update()
	{

	}
}
