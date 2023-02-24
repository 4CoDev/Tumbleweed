using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromEnumerable;

namespace Tumbleweed.Strings;

public sealed class StringFromObjects : ScalarEnvelope<string>
{
	public StringFromObjects(params object[] objects) : this
	(
		new EnumerableWithElements<object>(objects)
	)
	{
	}
	
	public StringFromObjects(IEnumerable<object> objects) : base
	(
		new StringWithStrings(
			new CommaSeparatedStrings(
				new StringsFromObjects(objects)),
			new ScalarOfValue<string>("."))
	)
	{
	}
}