using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Without.Item;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Integer = Tumbleweed.Number.Integer.System.Medium;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Integer.System.Medium.As;

public sealed class Natural : Envelope<Boolean.Any>
{
	public Natural(System::Int32 integer) : this
	(
		new Tumbleweed.Scalar.Of.Value<System::Int32>(integer)
	)
	{
	}
	
	public Natural(Scalar::Any<System::Int32> integer) : base
	(
		new Last<Boolean.Any>(
			new Integer::Bits(integer))
	)
	{
	}
}