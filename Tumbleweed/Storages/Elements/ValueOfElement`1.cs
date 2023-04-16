using Tumbleweed.Nullability;
using Tumbleweed.Scalars;

namespace Tumbleweed.Storages.Elements;

public sealed class ValueOfElement<T> :
	ScalarEnvelope<T>
	where T : notnull
{
	public ValueOfElement(IStorageElement<T> element) : base
	(
		new ValueOfNullable<T>(
			new NullableOfElement<T>(element))
	)
	{
	}
}