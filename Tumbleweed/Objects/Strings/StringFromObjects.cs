using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.Strings;
using Tumbleweed.Scalars;
using Tumbleweed.Strings;

namespace Tumbleweed.Objects.Strings;

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
			new ScalarValue<String>("."))
	)
	{
	}
}