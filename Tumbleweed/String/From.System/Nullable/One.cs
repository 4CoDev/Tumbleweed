using TW = Tumbleweed;

namespace Tumbleweed.String.From.System.Nullable;

public sealed class One : TW.Nullable.Envelope<Any>
{
	public One(global::System.String? nullable) : this
	(
		new TW.Nullable.From.System.One<global::System.String>(nullable)
	)
	{
	}
	
	public One(Scalar.Any<global::System.String?> nullable) : this
	(
		new TW.Nullable.From.System.One<global::System.String>(nullable)
	)
	{
	}
	
	public One
	(
		TW.Nullable.Any<global::System.String> nullables
	) : base
	(
		new TW.Nullable.With.Members<Any>(
			new NonNullable.One(
				new TW.Nullable.Value<global::System.String>(nullables)),
			new TW.Nullable.Has.Value(nullables))
	)
	{
	}
}