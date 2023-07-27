using Array = Tumbleweed.Array;
using Scalar = Tumbleweed.Scalar;
using Mutable = Tumbleweed.Mutable;
using Natural = Tumbleweed.Number.Natural;
using SCG = System.Collections.Generic;
using SystemArray = Tumbleweed.Array.Dimension.Spatial.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Dimension.Spatial.From;

public sealed class System<T> : Array::Any<T>
{
	public System(T[,,] array) : this
	(
		new Scalar::Of.Value<T[,,]>(array)
	)
	{
	}

	public System(Scalar::Any<T[,,]> array) =>
		this.array = array;

	public Mutable::Any<T> this
	[
		SCG::IEnumerable<Natural::Any> indices
	] =>
	(
		new SystemArray::Item.At.Index.Tumbleweed<T>(
			array,
			indices)
	);

	public SCG::IEnumerable<Natural::Any> Size =>
		new SystemArray::Size.Tumbleweed<T>(array);
	
	private readonly Scalar::Any<T[,,]> array;
}