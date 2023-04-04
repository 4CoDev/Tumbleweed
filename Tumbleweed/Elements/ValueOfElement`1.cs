using Tumbleweed.Nullability;
using Tumbleweed.Scalars;

namespace Tumbleweed.Elements;

public sealed class ValueOfElement<T> :
	ScalarEnvelope<T>
	where T : notnull
{
	public ValueOfElement(IElement<T> element) : base
	(
		new ValueOfNullable<T>(
			new NullabilityOfElement<T>(element))
	)
	{
	}
}