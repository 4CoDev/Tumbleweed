using Tumbleweed.Enumerable;

namespace Tumbleweed.String.From.System.NonNullable;

public sealed class Multiple : Envelope<Any>
{
	public Multiple
	(
		IEnumerable<global::System.String> strings
	) : base
	(
		new Selected<global::System.String, Any>(
			strings,
			@string => new One(@string))
	)
	{
	}
}