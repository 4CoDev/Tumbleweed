using System.Collections;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed._Object.Hash;

public sealed class HashFromObjects : ScalarEnvelope<Int32>
{
	public HashFromObjects
	(
		Object first,
		Object second,
		params Object[] umpteen
	) : this
	(
		new EnumerableWithElements<Object>(
			new EnumerableWithElements<Object>(first, second),
			umpteen)
	)
	{
	}
	
	public HashFromObjects(IEnumerable objects) : base
	(
		new HashFromHashes(
			new HashesOfObjects(objects))
	)
	{
	}
}