using Tumbleweed.Elements;

namespace Tumbleweed.Arrays;

public sealed class ArrayOfElement<T> :
	ArrayEnvelope<T>
	where T : notnull
{
	public ArrayOfElement(IElement<IArray<T>> element) : base
	(
		new ArrayOfScalar<T>(
			new ValueOfElement<IArray<T>>(element))
	)
	{
	}
}