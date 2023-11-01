using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using System = System;
using Property = Tumbleweed.Property;

namespace Tumbleweed.Enumerable.Item.From.Right.By.Length;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		SCG::IEnumerable<T> enumerable,
		System::Int32 length
	) : this
	(
		enumerable,
		new Value<System::Int32>(length)
	)
	{
	}
	
	public System
	(
		SCG::IEnumerable<T> enumerable,
		Any<Int32> length
	) : this
	(
		new SCG::List<T>(enumerable),
		length
	)
	{
	}
	
	public System
	(
		ICollection<T> collection,
		Any<Int32> length
	) : base
	(
		new Enumerable::Property.Value<T>(
			new Actual<SCG::IEnumerable<T>>(
				() => collection.Skip(collection.Count - length.Value)))
	)
	{
	}
}