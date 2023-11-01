using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;

namespace Tumbleweed.Mathematics.Boolean.From.System;

public sealed class One : Any
{
	public One(global::System.Boolean boolean) : this
	(
		new Value<global::System.Boolean>(boolean)
	)
	{
	}
	
	public One(Any<global::System.Boolean> boolean) =>
		this.boolean = boolean;

	public global::System.Boolean State =>
		boolean.Value;

	private readonly Any<global::System.Boolean> boolean;
}