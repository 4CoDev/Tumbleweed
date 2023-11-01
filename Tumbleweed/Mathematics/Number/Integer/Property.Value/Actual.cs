using Tumbleweed.Property.Output;

namespace Tumbleweed.Mathematics.Number.Integer.Property.Value;

public sealed class Actual : Any
{
	public Actual(Any<Any> property) =>
		this.property = property;

	public Boolean.Any IsPositive =>
		property.Value.IsPositive;

	public Mathematics.Number.Natural.Any Natural =>
		property.Value.Natural;

	private readonly Any<Any> property;
}