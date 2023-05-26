using Tumbleweed._Enumerable;
using Tumbleweed._Enumerable._String;
using Tumbleweed._String;

namespace Tumbleweed._Object.String;

public sealed class StringFromNullableObjects : StringEnvelope
{
	public StringFromNullableObjects(params Object?[] objects) : this
	(
		new EnumerableWithElements<Object?>(objects)
	)
	{
	}
	
	public StringFromNullableObjects(IEnumerable<Object?> objects) : base
	(
		new ConсatenatedStrings(
			new CommaSeparatedStrings(
				new SparesWhenObjectsIsNull(objects, "null")),
			new StringFromSystem("."))
	)
	{
	}
}