using Tumbleweed.Mathematics.Number.Natural;
using Immutable = Tumbleweed.Scalar.Immutable;
using Mutable = Tumbleweed.Scalar.Mutable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array.Dimension.Multi.Scalar.Value.Actual;

public sealed class Actual<T> : Any<T>
{
	public Actual(Immutable::Any<Any<T>> scalar) =>
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

	private readonly Immutable::Any<Any<T>> scalar;
}