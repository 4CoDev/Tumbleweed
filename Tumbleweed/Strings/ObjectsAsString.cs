using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromEnumerable;

namespace Tumbleweed.Strings;

public sealed class ObjectsAsString : ScalarEnvelope<string>
{
	public ObjectsAsString(IEnumerable<object> objects) : base
	(
		new StringWithStrings(
			new CommaSeparatedStrings(
				new ObjectsAsStrings(objects)),
			new ScalarOfValue<string>("."))
	)
	{
	}
}