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
		new EnumerableWithElements<IScalar<String>>(strings)
	)
	{
	}

	public StringWithStrings(IEnumerable<IScalar<String>> strings) : this
	(
		new ValuesOfScalars<String>(strings)
	)
	{
	}
	
	public StringWithStrings(IEnumerable<String> strings) : base
	(
		new ValueOfFunction<String>(
			() => string.Concat(strings))
	)
	{
	}
}