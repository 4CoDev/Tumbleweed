using Tumbleweed.Scalar.Immutable;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Natural.Scalar;

public sealed class Value : Natural.Any
{
	public Value(Any<Natural.Any> scalar) =>
		this.scalar = scalar;

	public IEnumerable<Boolean.Any> Bits =>
		scalar.Value.Bits;

	private readonly Any<Natural.Any> scalar;
}