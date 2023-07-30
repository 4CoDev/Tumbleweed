using Array = Tumbleweed.Array;
using Immutable = Tumbleweed.Scalar.Immutable;
using Enumerable = Tumbleweed.Enumerable;
using Natural = Tumbleweed.Number.Natural;
using SystemArray = Tumbleweed.Array.Dimension.Linear.System;
using SCG = System.Collections.Generic;
using Mutable = Tumbleweed.Scalar.Mutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Linear.From;

public sealed class System<T> : Array::Any<T>
{
	public System(params T[] array) : this
	(
		new Immutable::With.Value<T[]>(array)
	)
	{
	}

	public System(Immutable::Any<T[]> array) : this
	(
		array,
		new Enumerable::SingleItem.New<Natural::Any>(
			new SystemArray::Length.Tumbleweed<T>(array))
	)
	{
	}
	
	private System
	(
		Immutable::Any<T[]> array,
		SCG::IEnumerable<Natural::Any> size
	)
	{
		this.array = array;
		Size = size;
	}

	public Mutable::Any<T> this
	[
		SCG::IEnumerable<Natural::Any> indices
	] =>
	(
		new SystemArray::Item.At.Index.Tumbleweed<T>(array, indices)
	);
	
	private readonly Immutable::Any<T[]> array;

	public SCG::IEnumerable<Natural::Any> Size { get; }
}