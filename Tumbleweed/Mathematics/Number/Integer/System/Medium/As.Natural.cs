using Tumbleweed.Enumerable.Without.Item;
using Tumbleweed.Mathematics.Number.Integer.System.Medium;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;

using System = System;
using Property = Tumbleweed.Property;
using Integer = Tumbleweed.Mathematics.Number.Integer.System.Medium;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.As;

public sealed class Natural : Enumerable.Envelope<Boolean.Any>
{
	public Natural(System::Int32 integer) : this
	(
		new One<System::Int32>(integer)
	)
	{
	}
	
	public Natural(Any<System::Int32> integer) : base
	(
		new Last<Boolean.Any>(
			new Bits(integer))
	)
	{
	}
}