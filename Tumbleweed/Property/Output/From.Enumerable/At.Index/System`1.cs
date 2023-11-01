using Property = Tumbleweed.Property.Output;
using SCG = System.Collections.Generic;
using System = System;

namespace Tumbleweed.Property.Output.From.Enumerable.At.Index;

public sealed class System<T> : Property::Envelope<T>
{
	public System
	(
		SCG::IEnumerable<T> enumerable,
		System::Int32 index
	) : this
	(
		enumerable,
		new Property::With.Value<System::Int32>(index)
	)
	{
	}
	
	public System
	(
		SCG::IEnumerable<T> enumerable,
		Property::Any<System::Int32> index
	) : base
	(
		new Property::Function.Result.Actual<T>(
			() => enumerable.ElementAt(index.Value))
	)
	{
	}
}