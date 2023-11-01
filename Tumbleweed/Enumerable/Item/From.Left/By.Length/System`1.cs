using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using System = System;
using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Enumerable.Item.From.Left.By.Length;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		SCG::IEnumerable<T> enumerable,
		System::Int32 length
	) : this
	(
		enumerable,
		new Property::With.Value<Int32>(length)
	)
	{
	}
	
	public System
	(
		SCG::IEnumerable<T> enumerable,
		Property::Any<System::Int32> length
	) : this
	(
		new SCG::List<T>(enumerable),
		length
	)
	{
	}
	
	public System
	(
		SCG::ICollection<T> list,
		Property::Any<Int32> length
	) : base
	(
		new Enumerable::Property.Value<T>(
			new Actual<SCG::IEnumerable<T>>(
				() => list.Take(length.Value)))
	)
	{
	}
}