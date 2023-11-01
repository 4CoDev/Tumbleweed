using Tumbleweed.Array.Dimension.Multi;
using Tumbleweed.Mathematics.Number.Natural;
using Array = Tumbleweed.Array;
using Property = Tumbleweed.Property;
using Enumerable = Tumbleweed.Enumerable;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using SystemArray = Tumbleweed.Array.Dimension.Linear.System;
using SCG = System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Linear.From;

public sealed class System<T> : Any<T>
{
	public System(params T[] array) : this
	(
		new Property::Output.With.Value<T[]>(array)
	)
	{
	}

	public System(Property::Output.Any<T[]> array) : this
	(
		array,
		new Enumerable::SingleItem.New<Any>(
			new SystemArray::Length.Tumbleweed<T>(array))
	)
	{
	}
	
	private System
	(
		Property::Output.Any<T[]> array,
		SCG::IEnumerable<Any> size
	)
	{
		this.array = array;
		Size = size;
	}

	public Property::Transput.Any<T> this
	[
		SCG::IEnumerable<Any> indices
	] =>
	(
		new SystemArray::Item.At.Index.Tumbleweed<T>(array, indices)
	);
	
	private readonly Property::Output.Any<T[]> array;

	public SCG::IEnumerable<Any> Size { get; }
}