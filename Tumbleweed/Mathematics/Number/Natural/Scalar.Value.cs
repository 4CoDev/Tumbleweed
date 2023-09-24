using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Scalar.Immutable;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Natural.Scalar;

public sealed class Value : Any
{
	public Value(Any<Any> scalar) =>
		this.scalar = scalar;

	public IEnumerable<Boolean.Any> Bits =>
		scalar.Value.Bits;

	private readonly Any<Any> scalar;
}