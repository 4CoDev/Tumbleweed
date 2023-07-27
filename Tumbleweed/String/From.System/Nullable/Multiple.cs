using Tumbleweed.Enumerable;
using Tumbleweed.Nullable;
using TW = Tumbleweed;

namespace Tumbleweed.String.From.System.Nullable;

public sealed class Multiple : Enumerable.Envelope<
		Any<Any>>
{
	public Multiple
	(
		IEnumerable<global::System.String?> nullables
	) : this
	(
		new TW.Nullable.From.System.Multiple<global::System.String>(nullables)
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<TW.Nullable.Any<global::System.String>> nullables
	) : base
	(
		new Selected
		<
			TW.Nullable.Any<global::System.String>,
			TW.Nullable.Any<Any>
		>
		(
			nullables,
			nullable => new One(nullable)
		)
	)
	{
	}
}