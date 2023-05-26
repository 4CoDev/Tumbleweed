using Tumbleweed._Enumerable;
using Tumbleweed._String;

namespace Tumbleweed._Object.String;

public sealed class StringsFromObjects : EnumerableEnvelope<IString>
{
	public StringsFromObjects(params Object[] objects) : this
	(
		new EnumerableWithElements<Object>(objects)
	)
	{
	}
	
	public StringsFromObjects(IEnumerable<Object> objects) : base
	(
		new SelectedByExpression<Object, IString>(
			objects,
			@object => new EmptyWhenNull(
				new StringFromObject(@object)))
	)
	{
	}
}