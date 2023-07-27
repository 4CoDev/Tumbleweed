using Array = Tumbleweed.Array;
using Scalar = Tumbleweed.Scalar;
using Natural = Tumbleweed.Number.Natural;
using SCG = System.Collections.Generic;
using Mutable = Tumbleweed.Mutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Scalar;

public sealed class Value<T> : Array::Any<T>
{
	public Value(Scalar::Any<Array::Any<T>> scalar) =>
		this.scalar = scalar;

	public Mutable::Any<T> this[SCG::IEnumerable<Natural::Any> indices] =>
		scalar.Value[indices];

	public SCG::IEnumerable<Natural::Any> Size =>
		scalar.Value.Size;

	private readonly Scalar::Any<Array::Any<T>> scalar;
}