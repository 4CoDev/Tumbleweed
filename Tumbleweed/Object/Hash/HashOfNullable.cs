using Tumbleweed.Nullable.From.System;
using Tumbleweed.Scalar;

namespace Tumbleweed.Object.Hash;

public sealed class HashOfNullable : Envelope<Int32>
{
	public HashOfNullable(System.Object? nullable) : this
	(
		new One<System.Object>(nullable)
	)
	{
	}
	
	public HashOfNullable(Nullable.Any<System.Object> any) : base
	(
		new Scalar.Function.Result<Int32>(
			any.GetHashCode)
	)
	{
	}
}