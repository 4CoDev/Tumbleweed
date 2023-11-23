using Tumbleweed.Property;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Option.From.System;

namespace Tumbleweed.Object.Hash;

public sealed class HashOfNullable : Envelope<Int32>
{
	public HashOfNullable(System.Object? option) : this
	(
		new One<System.Object>(option)
	)
	{
	}
	
	public HashOfNullable
	(
		Property.Option.Any<System.Object> option
	) : base
	(
		new Actual<Int32>(
			option.GetHashCode)
	)
	{
	}
}