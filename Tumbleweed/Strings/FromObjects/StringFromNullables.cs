using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromEnumerable;

namespace Tumbleweed.Strings.FromObjects;

public sealed class StringFromNullables : ScalarEnvelope<string>
{
	public StringFromNullables(params object?[] objects) : this
	(
		new EnumerableWithElements<object?>(objects)
	)
	{
	}
	
	public StringFromNullables(IEnumerable<object?> objects) : base
	(
		new StringWithStrings(
			new CommaSeparatedStrings(
				new WordsWhenNulls(objects, "null")),
			new ScalarOfValue<string>("."))
	)
	{
	}
}