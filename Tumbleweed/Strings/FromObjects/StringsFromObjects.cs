using Tumbleweed.Enumerables;

namespace Tumbleweed.Strings.FromObjects;

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
				new NullableFromObject(@object)).Value)
	)
	{
	}
}