using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Property.Output;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Property;

public sealed class Value : Any
{
	public Value(Any<Any> property) =>
		this.property = property;
	
	public Mathematics.Number.Integer.Any Mantissa =>
		property.Value.Mantissa;

	public Mathematics.Number.Integer.Any Base =>
		property.Value.Base;

	public Mathematics.Number.Integer.Any Exponent =>
		property.Value.Exponent;

	private readonly Any<Any> property;
}