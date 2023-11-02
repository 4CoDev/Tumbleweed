using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace Tumbleweed.Mathematics.Boolean.From.System;

public sealed class One : Any
{
	public One(global::System.Boolean boolean) : this
	(
		new One<global::System.Boolean>(boolean)
	)
	{
	}
	
	public One(Any<global::System.Boolean> boolean) =>
		this.boolean = boolean;

	public global::System.Boolean State =>
		boolean.Value;

	private readonly Any<global::System.Boolean> boolean;
}