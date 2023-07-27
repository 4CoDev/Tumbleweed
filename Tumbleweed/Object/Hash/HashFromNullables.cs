using Tumbleweed.Enumerable;
using Tumbleweed.Nullable.From.System;
using Tumbleweed.Scalar;

namespace Tumbleweed.Object.Hash;

public sealed class HashFromNullables : Scalar.Envelope<Int32>
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
	
	public HashFromNullables(params Nullable.Any<System.Object>[] objects) : this
	(
		new Concatenated<Nullable.Any<System.Object>>(objects)
	)
	{
	}
	
	public HashFromNullables(IEnumerable<Nullable.Any<System.Object>> objects) : base
	(
		new HashFromHashes(
			new ZeroHashesWhenNull(objects))
	)
	{
	}
}