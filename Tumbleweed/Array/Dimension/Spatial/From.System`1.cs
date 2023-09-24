using Tumbleweed.Mathematics.Number.Natural;
using Array = Tumbleweed.Array;
using Immutable = Tumbleweed.Scalar.Immutable;
using Mutable = Tumbleweed.Scalar.Mutable;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using SCG = System.Collections.Generic;
using SystemArray = Tumbleweed.Array.Dimension.Spatial.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Dimension.Spatial.From;

public sealed class System<T> : Array::Any<T>
{
	public System(T[,,] array) : this
	(
		new Immutable::With.Value<T[,,]>(array)
	)
	{
	}

	public System(Immutable::Any<T[,,]> array)
	{
		Size = new SystemArray::Size.Tumbleweed<T>(array);
		this.array = array;
	}

	public Mutable::Any<T> this
	[
		SCG::IEnumerable<Any> indices
	] =>
	(
		new SystemArray::Item.At.Index.Tumbleweed<T>(
			array,
			indices)
	);

	public SCG::IEnumerable<Any> Size { get; }
	
	private readonly Immutable::Any<T[,,]> array;
}