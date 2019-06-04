using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
/// <summary>
/// 比较两个序列是否相等（长度和按顺序的每个元素相等）
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.sequenceequal?view=netframework-4.6.1
/// </summary>

public class SequenceEqual : MonoBehaviour
{
	class Pet : IEqualityComparer<Pet>{
		public string name;
		public int age;

		public bool Equals(Pet x, Pet y)
		{
			return x.name == y.name && x.age == y.age;
		}

		public int GetHashCode(Pet obj)
		{
			return base.GetHashCode();
		}
	}
	// Use this for initialization
	void Start()
	{
		Pet pet1 = new Pet { name = "dog1", age = 1 };
		Pet pet2 = new Pet { name = "dog2", age = 2 };
		Pet pet3 = new Pet { name = "dog3", age = 3};

		Pet[] pets1 = { pet1, pet2 };
		Pet[] pets2 = { pet1, pet2 };
		Pet[] pets3 = { pet2, pet1 };
		Pet[] pets4 = { pet1, pet3 };
		Debug.LogFormat("pets1 is SequenceEqual pets2: " + pets1.SequenceEqual(pets2, pet1));
		Debug.LogFormat("pets1 is SequenceEqual pets3: " + pets1.SequenceEqual(pets3, pet1));
		Debug.LogFormat("pets1 is SequenceEqual pets4: " + pets1.SequenceEqual(pets4, pet1));
	}

	// Update is called once per frame
	void Update()
	{

	}
}
