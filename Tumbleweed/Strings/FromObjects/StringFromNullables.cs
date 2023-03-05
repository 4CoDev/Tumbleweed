using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromEnumerable;

namespace Tumbleweed.Strings.FromObjects;

public sealed class StringFromNullables : ScalarEnvelope<String>
{
	public StringFromNullables(params Object?[] objects) : this
	(
		new EnumerableWithElements<Object?>(objects)
	)
	{
	}
	
	public StringFromNullables(IEnumerable<Object?> objects) : base
	(
		new StringWithStrings(
			new CommaSeparatedStrings(
				new WordsWhenNulls(objects, "null")),
			new ScalarOfValue<String>("."))
	)
	{
	}
}