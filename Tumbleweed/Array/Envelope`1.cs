using Tumbleweed.Mathematics.Number.Natural;
using Array = Tumbleweed.Array;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using Mutable = Tumbleweed.Scalar.Mutable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array;

public abstract class Envelope<T> : Array::Any<T>
{
	protected Envelope(Array::Any<T> array) =>
		this.array = array;

	public Mutable::Any<T> this
	[
		SCG::IEnumerable<Any> indices
	] =>
	(
		array[indices]
	);

	public SCG::IEnumerable<Any> Size =>
		array.Size;
	
	private readonly Array::Any<T> array;
}