using Tumbleweed.Enumerable;

namespace Tumbleweed.Boolean.System.From.Tumbleweed;

public sealed class Multiple : Envelope<global::System.Boolean>
{
	public Multiple(IEnumerable<Any> booleans) : base
	(
		new Selected<Any, global::System.Boolean>(
			booleans,
			boolean => boolean.State)
	)
	{
	}
}