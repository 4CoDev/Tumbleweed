using Array = Tumbleweed.Array;
using Natural = Tumbleweed.Number.Natural;
using Mutable = Tumbleweed.Mutable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array;

public abstract class Envelope<T> : Array::Any<T>
{
	protected Envelope(Array::Any<T> array) =>
		this.array = array;

	public Mutable::Any<T> this[IEnumerable<Natural::Any> indices] =>
		array[indices];

	public SCG::IEnumerable<Natural::Any> Size =>
		array.Size;
	
	private readonly Array::Any<T> array;
}