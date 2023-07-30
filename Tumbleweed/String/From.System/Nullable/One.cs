using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.From.System;
using Tumbleweed.Scalar.Nullable.With;
using TW = Tumbleweed;
using Value = Tumbleweed.Scalar.Nullable.Has.Value;

namespace Tumbleweed.String.From.System.Nullable;

public sealed class One : Envelope<Any>
{
	public One(global::System.String? nullable) : this
	(
		new One<global::System.String>(nullable)
	)
	{
	}
	
	public One(Scalar.Immutable.Any<global::System.String?> nullable) : this
	(
		new One<global::System.String>(nullable)
	)
	{
	}
	
	public One
	(
		Any<global::System.String> nullables
	) : base
	(
		new Members<Any>(
			new NonNullable.One(nullables),
			new Value(nullables))
	)
	{
	}
}