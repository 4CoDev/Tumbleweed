using TW = Tumbleweed;

namespace Tumbleweed.Boolean.From.System;

public sealed class One : Any
{
	public One(global::System.Boolean boolean) : this
	(
		new TW.Scalar.Of.Value<global::System.Boolean>(boolean)
	)
	{
	}
	
	public One(TW.Scalar.Any<global::System.Boolean> boolean) =>
		this.boolean = boolean;

	public global::System.Boolean State =>
		boolean.Value;

	private readonly TW.Scalar.Any<global::System.Boolean> boolean;
}