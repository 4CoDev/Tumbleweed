using Tumbleweed.Array.Dimension.Multi;
using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;
using Array = Tumbleweed.Array;
using Property = Tumbleweed.Property;
using SystemArray = Tumbleweed.Array.Dimension.Planar.System;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Planar.From;

public sealed class System<T> : Any<T>
{
	public System(T[,] array) : this
	(
		new One<T[,]>(array)
	)
	{
	}

	public System(Property::Output.Any<T[,]> array)
	{
		this.array = array;
		Size = new SystemArray::Size.Tumbleweed<T>(array);
	}

	public Property::Transput.Any<T> this
	[
		SCG::IEnumerable<Any> indices
	] =>
	(
		new SystemArray::Item.At.Index.Tumbleweed<T>(
			array,
			indices)
	);
	
	private readonly Property::Output.Any<T[,]> array;

	public SCG::IEnumerable<Any> Size { get; }
}