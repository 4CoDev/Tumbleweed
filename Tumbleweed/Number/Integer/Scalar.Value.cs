using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Integer.Scalar;

public sealed class Value : Any
{
	public Value(TW.Scalar.Any<Integer.Any> scalar) =>
		this.scalar = scalar;

	public Boolean.Any IsPositive =>
		scalar.Value.IsPositive;

	public Natural.Any Natural =>
		scalar.Value.Natural;

	private readonly TW.Scalar.Any<Integer.Any> scalar;
}