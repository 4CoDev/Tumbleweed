using Tumbleweed.Mathematics.Number.Natural;
using Property = Tumbleweed.Property.Transput;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array.Dimension.Multi;

public abstract class Envelope<T> : Any<T>
{
	protected Envelope(Any<T> array) =>
		this.array = array;

	public Property::Any<T> this
	[
		SCG::IEnumerable<Any> indices
	] =>
	(
		array[indices]
	);

	public SCG::IEnumerable<Any> Size =>
		array.Size;
	
	private readonly Any<T> array;
}