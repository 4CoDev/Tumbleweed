using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromEnumerable;

namespace Tumbleweed.Strings.FromObjects;

public sealed class StringFromObjects : ScalarEnvelope<String>
{
	public StringFromObjects(params Object[] objects) : this
	(
		new EnumerableWithElements<Object>(objects)
	)
	{
	}
	
	public StringFromObjects(IEnumerable<Object> objects) : base
	(
		new StringWithStrings(
			new CommaSeparatedStrings(
				new StringsFromObjects(objects)),
			new ScalarOfValue<String>("."))
	)
	{
	}
}