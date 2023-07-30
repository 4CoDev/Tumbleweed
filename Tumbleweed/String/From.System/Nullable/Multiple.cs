using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.From.System;
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
		new Multiple<global::System.String>(nullables)
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Any<global::System.String>> nullables
	) : base
	(
		new Selected
		<
			Any<global::System.String>,
			Any<Any>
		>
		(
			nullables,
			nullable => new One(nullable)
		)
	)
	{
	}
}