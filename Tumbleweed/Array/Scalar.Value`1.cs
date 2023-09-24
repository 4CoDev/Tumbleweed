using Tumbleweed.Mathematics.Number.Natural;
using Array = Tumbleweed.Array;
using Immutable = Tumbleweed.Scalar.Immutable;
using Mutable = Tumbleweed.Scalar.Mutable;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using SCG = System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Scalar;

public sealed class Value<T> : Array::Any<T>
{
	public Value(Immutable::Any<Array::Any<T>> scalar) =>
		this.scalar = scalar;

	public Mutable::Any<T> this
	[
		SCG::IEnumerable<Any> indices
	] =>
	(
		scalar.Value[indices]
	);

	public SCG::IEnumerable<Any> Size =>
		scalar.Value.Size;

	private readonly Immutable::Any<Array::Any<T>> scalar;
}