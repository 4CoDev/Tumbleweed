using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class StringWithStrings : ScalarEnvelope<String>
{
	public StringWithStrings(params String[] strings) : this
	(
		new EnumerableWithElements<String>(strings)
	)
	{
	}
	
	public StringWithStrings(params IScalar<String>[] strings) : this
	(
		new ValuesOfScalars<String>(strings)
	)
	{
	}
	
	public StringWithStrings(IEnumerable<String> strings) : base
	(
		new ResultOfFunction<String>(
			() => string.Concat(strings))
	)
	{
	}
}