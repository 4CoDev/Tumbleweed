using Array = Tumbleweed.Array;
using Scalar = Tumbleweed.Scalar;
using Enumerable = Tumbleweed.Enumerable;
using Natural = Tumbleweed.Number.Natural;
using SystemArray = Tumbleweed.Array.Dimension.Linear.System;
using SCG = System.Collections.Generic;
using Mutable = Tumbleweed.Mutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Linear.From;

public sealed class System<T> : Array::Any<T>
{
	public System(params T[] array) : this
	(
		new Scalar::Of.Value<T[]>(array)
	)
	{
	}

	public System(Scalar::Any<T[]> array) : this
	(
		array,
		new Enumerable::SingleItem.New<Natural::Any>(
			new SystemArray::Length.Tumbleweed<T>(array))
	)
	{
	}
	
	private System
	(
		Scalar::Any<T[]> array,
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
	
	private readonly Scalar::Any<T[]> array;

	public SCG::IEnumerable<Natural::Any> Size { get; }
}