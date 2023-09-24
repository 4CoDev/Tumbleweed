using Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Mathematics.Number.Integer.Scalar.Value;

public sealed class Actual : Any
{
	public Actual(Any<Any> scalar) =>
		this.scalar = scalar;

	public Boolean.Any IsPositive =>
		scalar.Value.IsPositive;

	public Mathematics.Number.Natural.Any Natural =>
		scalar.Value.Natural;

	private readonly Any<Any> scalar;
}