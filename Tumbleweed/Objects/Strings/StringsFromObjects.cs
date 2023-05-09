using Tumbleweed.Enumerables;
using Tumbleweed.Strings;

namespace Tumbleweed.Objects.Strings;

public sealed class StringsFromObjects : EnumerableEnvelope<String>
{
	public StringsFromObjects(params Object[] objects) : this
	(
		new EnumerableWithElements<Object>(objects)
	)
	{
	}
	
	public StringsFromObjects(IEnumerable<Object> objects) : base
	(
		new SelectedByExpression<Object, String>(
			objects,
			@object => new EmptyWhenNull(
				new StringFromObject(@object)).Value)
	)
	{
	}
}