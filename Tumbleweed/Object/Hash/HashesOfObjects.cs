using System.Collections;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.As;

namespace Tumbleweed.Object.Hash;

public sealed class HashesOfObjects : Envelope<Int32>
{
	public HashesOfObjects(IEnumerable objects) : this
	(
		new Type<System.Object>(objects)
	)
	{
	}
	
	public HashesOfObjects(IEnumerable<System.Object> objects) : base
	(
		new Selected<System.Object, Int32>(
			objects,
			@object => new HashOfObject(@object).Value)
	)
	{
	}
}