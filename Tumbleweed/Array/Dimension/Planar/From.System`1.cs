using Array = Tumbleweed.Array;
using Scalar = Tumbleweed.Scalar;
using SystemArray = Tumbleweed.Array.Dimension.Planar.System;
using Mutable = Tumbleweed.Mutable;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Planar.From;

public sealed class System<T> : Array::Any<T>
{
	public System(T[,] array) : this
	(
		new Scalar::Of.Value<T[,]>(array)
	)
	{
	}

	public System(Scalar::Any<T[,]> array)
	{
		this.array = array;
		Size = new SystemArray::Size.Tumbleweed<T>(array);
	}

	public Mutable::Any<T> this
	[
		SCG::IEnumerable<Natural::Any> indices
	] =>
	(
		new Dimension.Planar.System.Item.At.Index.Tumbleweed<T>(
			array,
			indices)
	);
	
	private readonly Scalar::Any<T[,]> array;

	public SCG::IEnumerable<Natural::Any> Size { get; }
}