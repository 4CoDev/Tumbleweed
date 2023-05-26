using Tumbleweed.Nullable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Storage.Element;

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