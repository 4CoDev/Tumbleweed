using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Nullable.From.System;

namespace Tumbleweed.Object.Hash;

public sealed class HashOfNullable : Envelope<Int32>
{
	public HashOfNullable(System.Object? nullable) : this
	(
		new One<System.Object>(nullable)
	)
	{
	}
	
	public HashOfNullable(Scalar.Nullable.Any<System.Object> any) : base
	(
		new Actual<Int32>(
			any.GetHashCode)
	)
	{
	}
}