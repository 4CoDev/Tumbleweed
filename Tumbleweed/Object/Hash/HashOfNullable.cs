using Tumbleweed.Property;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Nullable.From.System;

namespace Tumbleweed.Object.Hash;

public sealed class HashOfNullable : Envelope<Int32>
{
	public HashOfNullable(System.Object? nullable) : this
	(
		new One<System.Object>(nullable)
	)
	{
	}
	
	public HashOfNullable(Property.Nullable.Any<System.Object> any) : base
	(
		new Actual<Int32>(
			any.GetHashCode)
	)
	{
	}
}