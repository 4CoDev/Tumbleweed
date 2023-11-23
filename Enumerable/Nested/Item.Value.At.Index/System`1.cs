using Tumbleweed.Property.Output;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using Property = Tumbleweed.Property;
using System = System;

namespace Tumbleweed.Enumerable.Nested.Item.Value.At.Index;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		SCG::IEnumerable<SCG::IEnumerable<T>> enumerable,
		Any<System::Int32> index
	) : base
	(
		new Enumerable::Property.Value<T>(
			new Tumbleweed.Property.Output.From.Enumerable.At.Index.System<SCG::IEnumerable<T>>(
				enumerable,
				index))
	)
	{
	}
}