using Output = Tumbleweed.Property.Output;
using Option = Tumbleweed.Property.Option;
using Boolean = Tumbleweed.Mathematics.Boolean;

namespace Tumbleweed.Property.Option.Output.Value;

public sealed class Actual<T> : Option::Any<T>
{
	public Actual
	(
		Output::Any<Option::Any<T>> property
	)
	{
		this.property = property;
	}

	public T Value =>
		property.Value.Value;

	public Boolean::Any HasValue =>
		property.Value.HasValue;

	private readonly Output::Any<Option::Any<T>> property;
}