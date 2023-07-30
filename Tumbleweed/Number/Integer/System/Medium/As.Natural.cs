using Tumbleweed.Enumerable.Without.Item;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Integer = Tumbleweed.Number.Integer.System.Medium;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Integer.System.Medium.As;

public sealed class Natural : Enumerable.Envelope<Boolean.Any>
{
	public Natural(System::Int32 integer) : this
	(
		new Value<System::Int32>(integer)
	)
	{
	}
	
	public Natural(Any<System::Int32> integer) : base
	(
		new Last<Boolean.Any>(
			new Integer::Bits(integer))
	)
	{
	}
}