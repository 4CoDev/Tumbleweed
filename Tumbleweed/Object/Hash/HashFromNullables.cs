using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.From.System;

namespace Tumbleweed.Object.Hash;

public sealed class HashFromNullables : Scalar.Immutable.Envelope<Int32>
{
	public HashFromNullables(params System.Object?[] objects) : this
	(
		new Concatenated<System.Object?>(objects)
	)
	{
	}

	public HashFromNullables(IEnumerable<System.Object?> objects) : this
	(
		new Multiple<System.Object>(objects)
	)
	{
	}
	
	public HashFromNullables(params Any<System.Object>[] objects) : this
	(
		new Concatenated<Any<System.Object>>(objects)
	)
	{
	}
	
	public HashFromNullables(IEnumerable<Any<System.Object>> objects) : base
	(
		new HashFromHashes(
			new ZeroHashesWhenNull(objects))
	)
	{
	}
}