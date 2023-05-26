using Tumbleweed._Enumerable;

namespace Tumbleweed._String;

public sealed class StringsFromSystem : EnumerableEnvelope<IString>
{
	public StringsFromSystem
	(
		IEnumerable<String> strings
	) : base
	(
		new SelectedByExpression<String, IString>(
			strings,
			@string => new StringFromSystem(@string))
	)
	{
	}
}