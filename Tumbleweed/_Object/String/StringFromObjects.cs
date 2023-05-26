using Tumbleweed._Enumerable;
using Tumbleweed._Enumerable._String;
using Tumbleweed._String;

namespace Tumbleweed._Object.String;

public sealed class StringFromObjects : StringEnvelope
{
	public StringFromObjects(params Object[] objects) : this
	(
		new EnumerableWithElements<Object>(objects)
	)
	{
	}
	
	public StringFromObjects(IEnumerable<Object> objects) : base
	(
		new ConсatenatedStrings(
			new CommaSeparatedStrings(
				new StringsFromObjects(objects)),
			new StringFromSystem("."))
	)
	{
	}
}