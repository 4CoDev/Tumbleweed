using Tumbleweed.Enumerables;

namespace Tumbleweed.Strings;

public sealed class ObjectsAsStrings : EnumerableEnvelope<string>
{
	public ObjectsAsStrings(IEnumerable<object> objects) : base
	(
		new SelectedByExpression<object, string>(
			objects,
			@object => new EmptyableFromNullable(
				new ObjectAsNullableString(@object)).Value)
	)
	{
	}
}