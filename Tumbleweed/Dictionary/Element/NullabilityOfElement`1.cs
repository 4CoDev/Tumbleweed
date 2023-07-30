using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.Function;

namespace Tumbleweed.Dictionary.Element;

public sealed class NullabilityOfElement<T> :
	Envelope<T>
	where T : notnull
{
	public NullabilityOfElement(IDictionaryElement<T> element) : base
	(
		new Result<T>(
			() => element.Nullability)
	)
	{
	}
}