using Tumbleweed.Scalar.Immutable;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Scalar;

public sealed class Value : Real.Any
{
	public Value(Any<Real.Any> scalar) =>
		this.scalar = scalar;
	
	public Integer.Any Mantissa =>
		scalar.Value.Mantissa;

	public Integer.Any Base =>
		scalar.Value.Base;

	public Integer.Any Exponent =>
		scalar.Value.Exponent;

	private readonly Any<Real.Any> scalar;
}