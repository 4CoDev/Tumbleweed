using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class WordWhenNull : ScalarEnvelope<String>
{
	public WordWhenNull(String? origin, String word) : this
	(
		new ScalarValue<String?>(origin),
		new ScalarValue<String>(word)
	)
	{
	}
	
	public WordWhenNull(IScalar<String?> origin, String word) : this
	(
		origin,
		new ScalarValue<String>(word)
	)
	{
	}
	
	public WordWhenNull(String? origin, IScalar<String> word) : this
	(
		new ScalarValue<String?>(origin),
		word
	)
	{
	}
	
	public WordWhenNull
	(
		IScalar<String?> origin,
		IScalar<String> word
	) : base
	(
		new ResultOfFunction<String>(
			() => origin.Value ?? word.Value)
	)
	{
	}
}