using Tumbleweed.Nullable;

namespace Tumbleweed.Dictionary.Element;

public sealed class NullabilityOfElement<T> :
	Envelope<T>
	where T : notnull
{
	public NullabilityOfElement(IDictionaryElement<T> element) : base
	(
		new Nullable.Result.Of.Function<T>(
			() => element.Nullability)
	)
	{
	}
}