using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Scalar.Immutable;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Scalar;

public sealed class Value : Any
{
	public Value(Any<Any> scalar) =>
		this.scalar = scalar;
	
	public Mathematics.Number.Integer.Any Mantissa =>
		scalar.Value.Mantissa;

	public Mathematics.Number.Integer.Any Base =>
		scalar.Value.Base;

	public Mathematics.Number.Integer.Any Exponent =>
		scalar.Value.Exponent;

	private readonly Any<Any> scalar;
}