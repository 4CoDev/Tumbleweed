using System.Text;
using Godot;
using Tumbleweed.Mathematics.Boolean.From.Enumerable;

using System = System;
using Property = Tumbleweed.Property.Output;
using Single = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Exponent.Is;

public sealed class Negative : Boolean.Envelope
{
	public Negative(System::Single single) : this
	(
		new Property::With.Value.One<System::Single>(single)
	)
	{
	}
	
	public Negative(Property::Any<System::Single> single) : base
	(
			new Last(
				new Bit.Enumerable(single))
	)
	{
	}
}