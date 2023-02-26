using Tumbleweed.Enumerables;

namespace Tumbleweed.Strings;

public sealed class StringsFromObjects : EnumerableEnvelope<string>
{
	public StringsFromObjects(params object[] objects) : this
	(
		new EnumerableWithElements<object>(objects)
	)
	{
	}
	
	public StringsFromObjects(IEnumerable<object> objects) : base
	(
		new SelectedByExpression<object, string>(
			objects,
			@object => new EmptyableFromNullable(
				new NullableFromObject(@object)).Value)
	)
	{
	}
}