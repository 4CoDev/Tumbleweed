using Tumbleweed.Array.Dimension.Multi;
using Tumbleweed.Mathematics.Number.Natural;
using Array = Tumbleweed.Array;
using Property = Tumbleweed.Property;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using SCG = System.Collections.Generic;
using SystemArray = Tumbleweed.Array.Dimension.Spatial.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Dimension.Spatial.From;

public sealed class System<T> : Any<T>
{
	public System(T[,,] array) : this
	(
		new Property::Output.With.Value.One<T[,,]>(array)
	)
	{
	}

	public System(Property::Output.Any<T[,,]> array)
	{
		Size = new SystemArray::Size.Tumbleweed<T>(array);
		this.array = array;
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

	public SCG::IEnumerable<Any> Size { get; }
	
	private readonly Property::Output.Any<T[,,]> array;
}