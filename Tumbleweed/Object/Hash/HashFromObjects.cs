using System.Collections;
using Tumbleweed.Scalar.Immutable;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Object.Hash;

public sealed class HashFromObjects : Envelope<Int32>
{
	public HashFromObjects
	(
		System.Object first,
		System.Object second,
		params System.Object[] umpteen
	) : this
	(
		new Enumerable::Concatenated<System.Object>(
			new Enumerable::From.Array<System.Object>(first, second),
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