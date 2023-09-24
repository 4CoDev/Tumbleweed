using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Array = Tumbleweed.Array;
using Scalar = Tumbleweed.Scalar;
using SystemArray = Tumbleweed.Array.Dimension.Planar.System;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Planar.From;

public sealed class System<T> : Array::Any<T>
{
	public System(T[,] array) : this
	(
		new Value<T[,]>(array)
	)
	{
	}

	public System(Scalar::Immutable.Any<T[,]> array)
	{
		this.array = array;
		Size = new SystemArray::Size.Tumbleweed<T>(array);
	}

	public Scalar::Mutable.Any<T> this
	[
		SCG::IEnumerable<Any> indices
	] =>
	(
		new SystemArray::Item.At.Index.Tumbleweed<T>(
			array,
			indices)
	);
	
	private readonly Scalar::Immutable.Any<T[,]> array;

	public SCG::IEnumerable<Any> Size { get; }
}