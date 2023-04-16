using Tumbleweed.Nullability;
using Tumbleweed.Scalars;

namespace Tumbleweed.Dictionaries.Elements;

public sealed class ValueOfElement<T> :
	ScalarEnvelope<T>
	where T : notnull
{
	public ValueOfElement(IDictionaryElement<T> element) : base
	(
		new ValueOfNullable<T>(
			new NullabilityOfElement<T>(element))
	)
	{
	}
}