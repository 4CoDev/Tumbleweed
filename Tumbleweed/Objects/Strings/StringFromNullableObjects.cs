using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.Strings;
using Tumbleweed.Scalars;
using Tumbleweed.Strings;

namespace Tumbleweed.Objects.Strings;

public sealed class StringFromNullableObjects : ScalarEnvelope<String>
{
	public StringFromNullableObjects(params Object?[] objects) : this
	(
		new EnumerableWithElements<Object?>(objects)
	)
	{
	}
	
	public StringFromNullableObjects(IEnumerable<Object?> objects) : base
	(
		new StringWithStrings(
			new CommaSeparatedStrings(
				new SparesWhenObjectsIsNull(objects, "null")),
			new ScalarValue<String>("."))
	)
	{
	}
}