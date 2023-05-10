using System.Collections;
using Tumbleweed.Enumerables;

namespace Tumbleweed.Objects.Hashes;

public sealed class HashesOfObjects : EnumerableEnvelope<Int32>
{
	public HashesOfObjects(IEnumerable objects) : this
	(
		new ElementsAsType<Object>(objects)
	)
	{
	}
	
	public HashesOfObjects(IEnumerable<Object> objects) : base
	(
		new SelectedByExpression<Object, Int32>(
			objects,
			@object => new HashOfObject(@object).Value)
	)
	{
	}
}